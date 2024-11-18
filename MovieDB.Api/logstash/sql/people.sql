WITH NotableWorks AS (SELECT DISTINCT ON (m."Id") p."Id" AS personId,
                                                  jsonb_build_object(
                                                          'mediaId', m."Id",
                                                          'title', m."Title",
                                                          'year', m."Year",
                                                          'role', COALESCE(cm."Character", crm."Job")
                                                  )::text      AS workData
                      FROM "People" p
                               LEFT JOIN "CastMembers" cm ON cm."PersonId" = p."Id"
                               LEFT JOIN "CrewMembers" crm ON crm."PersonId" = p."Id"
                               LEFT JOIN "Media" m ON m."Id" = COALESCE(cm."MediaId", crm."MediaId")
                      WHERE EXTRACT(EPOCH FROM p."UpdatedAt") > :sql_last_value
                      ORDER BY m."Id", m."Year" DESC
                      LIMIT 10)

SELECT p."Id"                            AS "id",
       p."Name"                          AS "name",
       p."BirthName"                     AS "birthName",
       EXTRACT(EPOCH FROM p."Birthday")  AS "birthday",
       EXTRACT(EPOCH FROM p."Deathday")  AS "deathday",
       p."Gender"                        AS "gender",
       p."Biography"                     AS "biography",
       p."BirthPlace"                    AS "birthPlace",
       p."Photo"                         AS "photo",
       p."Popularity"::float             AS "popularity",
       EXTRACT(EPOCH FROM p."CreatedAt") AS "created",
       EXTRACT(EPOCH FROM p."UpdatedAt") AS "updated",
       -- External IDs
       pe."Imdb"                         AS "imdbId",
       pe."Tvdb"                         AS "tvdbId",
       pe."Moviedb"                      AS "moviedbId",
       -- Notable works
       COALESCE(
               (SELECT array_to_json(array_agg(workData))
                FROM NotableWorks nw
                WHERE nw.personId = p."Id"),
               '[]'::json
       )::text                                 AS "notableWorks"
FROM "People" p
         LEFT JOIN "PersonExternalIds" pe ON p."Id" = pe."PersonId"
WHERE EXTRACT(EPOCH FROM p."UpdatedAt") > :sql_last_value;
