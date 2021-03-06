﻿using MakeYourJournal.DAL.Dtos;
using MakeYourJournal.DAL.Entities;
using System;

namespace MakeYourJournal.DAL.Seed
{
    public class JournalSeedData
    {
        public IssueSeedDto[] Issues { get; set; } =
        {
            new IssueSeedDto { Volume = 45, Number = 6, Name = "Nyári szám", Description = "A 2017/2018-as tavaszi félév utolsó, közéleti száma.", AllTime = 477, Deadline = new DateTime(2018, 4, 8), ExpectedPageCount = 36, CopyNumber = 800},
            new IssueSeedDto { Volume = 45, Number = 5, Name = "Simonyi szám", Description = "A 2018-as Simonyi Konferencia hivatalos kiadványa.", AllTime = 476, Deadline = new DateTime(2018, 3, 11), ExpectedPageCount = 48, CopyNumber = 1500}
        };

        public ArticleSeedDto[] Articles { get; set; } =
        {
            new ArticleSeedDto { Title = "Most akkor mit is kell zsebre tenni?", Topic = "Konferencia főrendezői interjú", AllTime = 476},
            new ArticleSeedDto { Title = "A Schönherz óriáskijelző titkai", Topic = "Interjú Kiss Ádámmal", AllTime = 476},
            new ArticleSeedDto { Title = "Nézz mélyebbre!", Topic = "Body kiállítás", AllTime = 477},
            new ArticleSeedDto { Title = "Az 1%, aki mindent használ grafikából", Topic = "Interjú Gulyás Gergellyel", AllTime = 477},
            new ArticleSeedDto { Title = "Újra kell gondolni a szabályozást?", Topic = "ESZK vendégcikk", AllTime = 477},
            new ArticleSeedDto { Title = "Római Vakáció", Topic = "Timi és Bence utazása", AllTime = 477}
        };

        public TodoSeedDto[] Todos { get; set; } =
        {
            new TodoSeedDto {Name = "Interjúidőpont egyeztetése", Done = true, ArticleTitle = "Az 1%, aki mindent használ grafikából"},
            new TodoSeedDto {Name = "Fotós felkérése", Done = true, ArticleTitle = "Az 1%, aki mindent használ grafikából"},
            new TodoSeedDto {Name = "Interjú felvétele", Done = false, ArticleTitle = "Az 1%, aki mindent használ grafikából"},
            new TodoSeedDto {Name = "Interjú legépelése", Done = false, ArticleTitle = "Az 1%, aki mindent használ grafikából"},
            new TodoSeedDto {Name = "Jegyek szerzése", Done = true, ArticleTitle = "Nézz mélyebbre!"},
            new TodoSeedDto {Name = "Látogatás", Done = false, ArticleTitle = "Nézz mélyebbre!"},
            new TodoSeedDto {Name = "Cikkírás", Done = false, ArticleTitle = "Nézz mélyebbre!"},
            new TodoSeedDto {Name = "Cikk fogadása", Done = true, ArticleTitle = "Újra kell gondolni a szabályozást?"},
            new TodoSeedDto {Name = "Megírás", Done = true, ArticleTitle = "Római Vakáció"}
        };

        public NoteSeedDto[] Notes { get; set; } =
        {
            new NoteSeedDto {Name = "Képek", Description = "Megint egyetlen képet se kaptunk, a tördelők keressenek valami stock fotót!", ArticleTitle = "Újra kell gondolni a szabályozást?"},
            new NoteSeedDto {Name = "Youtube link", Description = "A játék lanch trailerje szerepeljen QR kóddal és youtube linkkel a cikk végén", ArticleTitle = "Az 1%, aki mindent használ grafikából"}
        };

        public class IssueSeedDto
        {
            public int Volume { get; set; }
            public int Number { get; set; }
            public int AllTime { get; set; }
            public string Name { get; set; }
            public DateTime Deadline { get; set; }
            public string Description { get; set; }
            public int ExpectedPageCount { get; set; }
            public int CopyNumber { get; set; }
        }

        public class ArticleSeedDto
        {
            public string Title { get; set; }
            public string Topic { get; set; }

            public int AllTime { get; set; }
        }

        public class TodoSeedDto
        {
            public string Name { get; set; }
            public bool Done { get; set; }

            public string ArticleTitle { get; set; }
        }

        public class NoteSeedDto
        {
            public string Name { get; set; }
            public string Description { get; set; }

            public string ArticleTitle { get; set; }
        }
        
    }
}
