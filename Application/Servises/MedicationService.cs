using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public class MedicationService : IBaseService<Medication>
    {
        private readonly IBaseRepository<Medication> _medicationRepository;

        public MedicationService(IBaseRepository<Medication> medicationRepository)
        {
            _medicationRepository = medicationRepository;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            Medication medication = await GetAsync(id);

            if (medication == null)
            {
                return false;
            }

            await _medicationRepository.DeleteAsync(medication.Id);
            return true;
        }

        public async Task<IEnumerable<Medication>> GetAllAsync()
        {
            return await _medicationRepository.GetAllAsync();
        }

        public async Task<Medication> GetAsync(Guid id)
        {
            return await _medicationRepository.GetAsync(id);
        }

        public async Task<Medication> InsertAsync(Medication medication)
        {
            return await _medicationRepository.InsertAsync(medication);
        }

        public async Task<bool> UpdateAsync(Medication medication)
        {
            var existingMedication = await _medicationRepository.GetAsync(medication.Id);

            if (existingMedication is null)
            {
                return false;
            }

            existingMedication.Name = medication.Name;
            existingMedication.Manufacturer = medication.Manufacturer;
            existingMedication.Price = medication.Price;
            existingMedication.Quantity = medication.Quantity;

            return await _medicationRepository.UpdateAsync(existingMedication);
        }
    }
}
