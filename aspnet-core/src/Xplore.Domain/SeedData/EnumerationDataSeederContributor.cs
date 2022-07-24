using System;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Xplore.Models;

namespace Xplore
{
    public class
    EnumerationDataSeederContributor
    : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Enumeration, Guid> _enumerationRepository;

        public EnumerationDataSeederContributor(
            IRepository<Enumeration, Guid> enumerationRepository
        )
        {
            _enumerationRepository = enumerationRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _enumerationRepository.GetCountAsync() <= 0)
            {
                // Not Allowed Stuff
                await _enumerationRepository
                    .InsertAsync(new Enumeration {
                        DisplayEn = "Pets",
                        Type = EnumType.NotAllowedStuff
                    },
                    autoSave: true);

                await _enumerationRepository
                    .InsertAsync(new Enumeration {
                        DisplayEn = "Smoking",
                        Type = EnumType.NotAllowedStuff
                    },
                    autoSave: true);

                // not Suitable For
                await _enumerationRepository
                    .InsertAsync(new Enumeration {
                        DisplayEn = "High-heeled shoes",
                        Type = EnumType.NotSuitableFor
                    },
                    autoSave: true);

                await _enumerationRepository
                    .InsertAsync(new Enumeration {
                        DisplayEn = "Sandals or flip flops",
                        Type = EnumType.NotSuitableFor
                    },
                    autoSave: true);
                await _enumerationRepository
                    .InsertAsync(new Enumeration {
                        DisplayEn = "Children under 5 years",
                        DisplayFr = "Enfant Mois de 5 ans",
                        Type = EnumType.NotSuitableFor
                    },
                    autoSave: true);

                await _enumerationRepository
                    .InsertAsync(new Enumeration {
                        DisplayEn = "Pregnant women",
                        DisplayFr = "Femme Enceinte",
                        Type = EnumType.NotSuitableFor
                    },
                    autoSave: true);

                await _enumerationRepository
                    .InsertAsync(new Enumeration {
                        DisplayEn = "Wheelchair users",
                        DisplayFr = "Personne avec Chaise Roulante",
                        Type = EnumType.NotSuitableFor
                    },
                    autoSave: true); // Required Stuff
                await _enumerationRepository
                    .InsertAsync(new Enumeration {
                        DisplayEn = "Lunch",
                        DisplayFr = "Dejeuner",
                        Type = EnumType.RequiredStuff
                    },
                    autoSave: true);

                await _enumerationRepository
                    .InsertAsync(new Enumeration {
                        DisplayEn = "Swimming clothes",
                        DisplayFr = "maillot",
                        Type = EnumType.RequiredStuff
                    },
                    autoSave: true);
            }
        }
    }
}
