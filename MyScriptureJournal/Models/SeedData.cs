using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyScriptureJournal.Data;


namespace MyScriptureJournal.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyScriptureJournalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MyScriptureJournalContext>>()))
            {
                // Look for any movies.
                if (context.Journal.Any())
                {
                    return;   // DB has been seeded
                }

                context.Journal.AddRange(
                    new Journal
                    {
                        Book = "Nephi",
                        Chapter = "1",
                        Verse = "1",
                        EntryDate = DateTime.Parse("2020-2-11"),
                        Note = "He was highly favored. He did what God wanted.",
                    },

                    new Journal
                    {
                        Book = "Nephi",
                        Chapter = "6:",
                        Verse = "4-5",
                        EntryDate = DateTime.Parse("2020-1-12"),
                        Note = "They Will Prosper.",
                    },

                    new Journal
                    {
                        Book = "Matthew",
                        Chapter = "10",
                        Verse = "13",
                        EntryDate = DateTime.Parse("2020-2-20"),
                        Note = "Peace.",
                    },

                    new Journal
                    {
                        Book = "Philippians",
                        Chapter = "4",
                        Verse = "7",
                        EntryDate = DateTime.Parse("2020-2-12"),
                        Note = "Peace through Jesus Christ.s",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
