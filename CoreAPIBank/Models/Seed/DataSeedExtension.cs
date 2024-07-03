using CoreAPIBank.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoreAPIBank.Models.Seed
{
    public static class DataSeedExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            UserCardInfo userCardInfo = new()
            {
                ID = 1,
                Balance = 100000,
                CardLimit = 100000,
                CardNumber = "2222 2222 2222 2222",
                CardUserName = "Test Data",
                CCV = "333",
                ExpiryMonth = 12,
                ExpiryYear = 2030
            };

            modelBuilder.Entity<UserCardInfo>().HasData(userCardInfo);
        }
    }
}
