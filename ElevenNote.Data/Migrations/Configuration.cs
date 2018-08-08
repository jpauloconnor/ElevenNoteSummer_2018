namespace ElevenNote.Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ElevenNote.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ElevenNote.Data.ApplicationDbContext";
        }

        protected override void Seed(ElevenNote.Data.ApplicationDbContext context)
        {
            var notes = new List<Note>
            {
                new Note{Title = "Eat", Content="Pizza tonight", OwnerID = Guid.NewGuid(), CreatedUtc = new DateTimeOffset()},
                new Note{Title = "Teach", Content=".NET Course", OwnerID = Guid.NewGuid(), CreatedUtc = new DateTimeOffset()},
                new Note{Title = "Eat", Content="Pizza tonight", OwnerID = Guid.NewGuid(), CreatedUtc = new DateTimeOffset()}
            };

            notes.ForEach(n => context.Notes.Add(n));
            context.SaveChanges();

        }
    }
}
