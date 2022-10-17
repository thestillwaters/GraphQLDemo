# GraphQLDemo
https://www.youtube.com/watch?v=5gxwIzrMs8w&amp;list=PLA8ZIAm2I03g9z705U3KWJjTv0Nccw9pj&amp;index=3

Ep5

1. SchoolDbContext
Add public SchoolDbContext(DbContextOptions<SchoolDbContext> options)
            : base(options)
        {
        }
        
2. cmd dotnet tool install --global dotnet-ef <br />
Stop the app and dotnet ef migrations add Initial

if has school.db, db-sha, db-wal.
dotnet ef migrations remove
