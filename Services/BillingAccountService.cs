using Patient_Management_System.Models;
using Patient_Management_System.Data;

namespace Patient_Management_System.Services
{
    public class BillingAccountService(AppDbContext context)
    {
        private readonly AppDbContext _context = context;

        public async Task<Billing> CreateAccountAsync(int patientId)
        {
            var billing = new Billing
            {
                PatientId = patientId,
                AccountId = Guid.NewGuid().ToString(),
                Status = "ACTIVE"
            };

            _context.Billings.Add(billing);
            await _context.SaveChangesAsync();
            return billing;
        }
    }
}