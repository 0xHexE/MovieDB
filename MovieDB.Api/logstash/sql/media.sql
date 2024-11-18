SELECT m."Id"                                                                                       as "id",
       m."Title"                                                                                    as "title",
       m."OriginalTitle"                                                                            as "originalTitle",
       m."Type"                                                                                     as "type",
       m."Slug"                                                                                     as "slug",
       m."Description"                                                                              as "description",
       m."Year"                                                                                     as "yearReleased",
       m."Runtime"                                                                                  as "runtime",
       m."Status"                                                                                   as "status",
       m."Rated"                                                                                    as "rated",
       m."Language"                                                                                 as "language",
       m."Country"                                                                                  as "country",
       m."Poster"                                                                                   as "poster",
       m."Background"                                                                               as "background",
       m."Logo"                                                                                     as "logo",
       m."Budget"::float                                                                            as "budget",
       m."BoxOffice"::float                                                                         as "boxOffice",
       m."TotalSeasons"::integer                                                                    as "totalSeasons",
       m."Homepage"                                                                                 as "homePage",
       m."Tagline"                                                                                  as "tagLine",
       m."SpokenLanguages"                                                                          as "spokenLanguages",
       EXTRACT(EPOCH FROM m."Released")                                                             as "released",
       EXTRACT(EPOCH FROM m."CreatedAt")                                                            as "created",
       EXTRACT(EPOCH FROM m."UpdatedAt")                                                            as "updated",

       -- Genres as array
       array_to_json(array_agg(DISTINCT g."Name") FILTER (WHERE g."Name" IS NOT NULL))              as "genres",

       -- Keywords as array
       array_to_json(array_agg(DISTINCT k."Name") FILTER (WHERE k."Name" IS NOT NULL))              as "keywords",

       -- Production Companies
       array_to_json(array_agg(DISTINCT jsonb_build_object(
               'id', pc."Id",
               'name', pc."Name",
               'originCountry', pc."OriginCountry"
                                        ))
                     FILTER (WHERE pc."Id" IS NOT NULL))::text                                            as "productionCompanies",

       -- Certifications
       array_to_json(array_agg(DISTINCT jsonb_build_object(
               'country', c."Country",
               'rating', c."Rating"
                                        )) FILTER (WHERE c."Id" IS NOT NULL))::text                       as "certifications",

       -- Awards
       array_to_json(array_agg(DISTINCT jsonb_build_object(
               'name', a."Name",
               'category', a."Category",
               'year', a."Year",
               'isWinner', a."IsWinner"
                                        )) FILTER (WHERE a."Id" IS NOT NULL))::text                       as "awards",

       -- Cast Members (limited to main cast)
       array_to_json(array_agg(DISTINCT jsonb_build_object(
               'character', cm."Character",
               'personName', p."Name",
               'personId', p."Id"
                                        )) FILTER (WHERE cm."Id" IS NOT NULL AND cm."Order" <= 10))::text as "mainCast",

       -- Directors and Writers
       array_to_json(array_agg(DISTINCT jsonb_build_object(
               'name', p2."Name",
               'id', p2."Id",
               'job', crm."Job"
                                        ))
                     FILTER (WHERE crm."Id" IS NOT NULL AND crm."Job" IN ('Director', 'Writer')))::text   as "creators"

FROM "Media" m
         LEFT JOIN "MediaGenres" mg ON m."Id" = mg."MediaId"
         LEFT JOIN "Genres" g ON mg."GenresId" = g."Id"
         LEFT JOIN "MediaKeywords" mk ON m."Id" = mk."MediaId"
         LEFT JOIN "Keywords" k ON mk."KeywordsId" = k."Id"
         LEFT JOIN "MediaProductionCompanies" mpc ON m."Id" = mpc."MediaId"
         LEFT JOIN "ProductionCompanies" pc ON mpc."ProductionCompaniesId" = pc."Id"
         LEFT JOIN "MediaCertifications" mc ON m."Id" = mc."MediaId"
         LEFT JOIN "Certifications" c ON mc."CertificationId" = c."Id"
         LEFT JOIN "Awards" a ON m."Id" = a."MediaId"
         LEFT JOIN "CastMembers" cm ON m."Id" = cm."MediaId"
         LEFT JOIN "People" p ON cm."PersonId" = p."Id"
         LEFT JOIN "CrewMembers" crm ON m."Id" = crm."MediaId"
         LEFT JOIN "People" p2 ON crm."PersonId" = p2."Id"
WHERE EXTRACT(EPOCH FROM m."UpdatedAt") > :sql_last_value
GROUP BY m."Id"
