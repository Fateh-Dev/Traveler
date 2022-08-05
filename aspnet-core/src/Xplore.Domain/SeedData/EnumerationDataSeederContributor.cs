using System;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Guids;
using Xplore.Models;

namespace Xplore
{
    public class
    EnumerationDataSeederContributor
    : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Enumeration, Guid> _enumerationRepository;

        private readonly IRepository<Tourist, Guid> _touristRepository;

        private readonly IRepository<Guide, Guid> _guideRepository;

        private readonly IGuidGenerator _guidGenerator;

        public EnumerationDataSeederContributor(
            IGuidGenerator guidGenerator,
            IRepository<Enumeration, Guid> enumerationRepository,
            IRepository<Tourist, Guid> touristRepository,
            IRepository<Guide, Guid> guideRepository
        )
        {
            _guidGenerator = guidGenerator;
            _enumerationRepository = enumerationRepository;
            _touristRepository = touristRepository;
            _guideRepository = guideRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            await SeedEnumerationsAsync();
            await SeedTouristsAsync();
            await SeedGuidesAsync();
        }

        private async Task SeedEnumerationsAsync()
        {
            if (await _enumerationRepository.GetCountAsync() <= 0)
            {
                // Not Allowed Stuff
                await _enumerationRepository
                    .InsertAsync(new Enumeration {
                        DisplayEn = "Pets",
                        Code = "Pets",
                        Value = "Pets",
                        Type = EnumType.NotAllowedStuff
                    },
                    autoSave: true);

                await _enumerationRepository
                    .InsertAsync(new Enumeration {
                        DisplayEn = "Smoking",
                        Code = "Smoking",
                        Value = "Smoking",
                        Type = EnumType.NotAllowedStuff
                    },
                    autoSave: true);

                // not Suitable For
                await _enumerationRepository
                    .InsertAsync(new Enumeration {
                        DisplayEn = "High-heeled shoes",
                        Code = "High-heeled shoes",
                        Value = "High-heeled shoes",
                        Type = EnumType.NotSuitableFor
                    },
                    autoSave: true);

                await _enumerationRepository
                    .InsertAsync(new Enumeration {
                        DisplayEn = "Sandals or flip flops",
                        Code = "Sandals or flip flops",
                        Value = "Sandals or flip flops",
                        Type = EnumType.NotSuitableFor
                    },
                    autoSave: true);
                await _enumerationRepository
                    .InsertAsync(new Enumeration {
                        DisplayEn = "Children under 5 years",
                        DisplayFr = "Enfant Mois de 5 ans",
                        Code = "Enfant Mois de 5 ans",
                        Value = "Enfant Mois de 5 ans",
                        Type = EnumType.NotSuitableFor
                    },
                    autoSave: true);

                await _enumerationRepository
                    .InsertAsync(new Enumeration {
                        DisplayEn = "Pregnant women",
                        Code = "Pregnant women",
                        Value = "Pregnant women",
                        DisplayFr = "Femme Enceinte",
                        Type = EnumType.NotSuitableFor
                    },
                    autoSave: true);

                await _enumerationRepository
                    .InsertAsync(new Enumeration {
                        DisplayEn = "Wheelchair users",
                        Code = "Wheelchair users",
                        Value = "Wheelchair users",
                        DisplayFr = "Personne avec Chaise Roulante",
                        Type = EnumType.NotSuitableFor
                    },
                    autoSave: true); // Required Stuff
                await _enumerationRepository
                    .InsertAsync(new Enumeration {
                        DisplayEn = "Lunch",
                        DisplayFr = "Dejeuner",
                        Code = "Dejeuner",
                        Value = "Dejeuner",
                        Type = EnumType.RequiredStuff
                    },
                    autoSave: true);

                await _enumerationRepository
                    .InsertAsync(new Enumeration {
                        DisplayEn = "Swimming clothes",
                        DisplayFr = "Maillot",
                        Code = "Maillot",
                        Value = "Maillot",
                        Type = EnumType.RequiredStuff
                    },
                    autoSave: true);
            }
        }

        private async Task SeedTouristsAsync()
        {
            if (await _touristRepository.GetCountAsync() <= 0)
            {
                await _touristRepository
                    .InsertAsync(new Tourist(_guidGenerator.Create())
                    {
                        Firstname = "Fateh",
                        Lastname = "Djehinet",
                        Email = "fateh_djehinet@outlook.com",
                        Gender = Gender.Man,
                        Birthday = new DateTime(1993, 3, 4),
                        Wilaya = "Jijel",
                        ZipCode = 18000,
                        Address = "Cite Bouhali - Tassoust - Jijel",
                        Address2 = "Cite Semrouni - Ouled Fayet - Alger"
                    },
                    autoSave: true);
                await _touristRepository
                    .InsertAsync(new Tourist(_guidGenerator.Create())
                    {
                        Firstname = "Hichem",
                        Lastname = "Boudjemia",
                        Email = "Hicham.B@gmail.com",
                        Gender = Gender.Man,
                        Birthday = new DateTime(1991, 3, 4),
                        Wilaya = "Jijel",
                        ZipCode = 18000,
                        Address = "Cite Elmoudjahidin - Tassoust - Jijel"
                    },
                    autoSave: true);
            }
        }

        private async Task SeedGuidesAsync()
        {
            if (await _guideRepository.GetCountAsync() <= 0)
            {
                await _guideRepository
                    .InsertAsync(new Guide {
                        Firstname = "Amine",
                        Lastname = "Aiche",
                        Email = "Amine.A@gmail.com",
                        Gender = Gender.Man,
                        Birthday = new DateTime(1992, 7, 14),
                        Wilaya = "Jijel",
                        ZipCode = 18000,
                        Address = "Cite Elmoudjahidin - Tassoust - Jijel"
                    },
                    autoSave: true);
            }
        }
    }
}
