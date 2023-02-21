using System.ComponentModel.Design;

namespace ConstructionApi.Models
{
    public static class ConstructionDataSeeding
    {
        public static readonly Client[] Clients = 
        {
             new Client
             {
                 ClientID = 1,
                 Name = "John Smith",
                 Email = "john.smith@example.com",
                 Phone = "555-1234",
                 UserID = 2
             },
             new Client
             {
                 ClientID = 2,
                 Name = "Jane Doe",
                 Email = "jane.doe@example.com",
                 Phone = "555-5678",
                 UserID = 3
             }
        };
        public static readonly Company[] Companies =
       {
            new Company
            {
                CompanyID= 1,
                Name = "ABC Company",
                Address = "123 Main Street",
                Email = "info@abccompany.com",
                Phone = "050-555-1234"
            },
            new Company
            {
                CompanyID= 2,
                Name = "XYZ Company",
                Address = "456 Maple Avenue",
                Email = "info@xyzcompany.com",
                Phone = "050-555-5678"
            }
        };

        public static readonly ConstructionRequestStatus[] ConstructionRequestStatusList =
        {
            new ConstructionRequestStatus
            {
                ConstructionRequestStatusID= 1,
                Name = "Submitted"
            },
             new ConstructionRequestStatus
            {
                ConstructionRequestStatusID= 2,
                Name = "Pending Payment"
            },
              new ConstructionRequestStatus
            {
                  ConstructionRequestStatusID= 3,
                Name = "Payment Successful"
            },
             new ConstructionRequestStatus
            {
                 ConstructionRequestStatusID= 4,
                Name = "In Progress"
            },
            new ConstructionRequestStatus
            {
                ConstructionRequestStatusID= 5,
                Name = "Completed"
            }
        };

        public static readonly ProjectStatus[] ProjectStatusList =
        {
             new ProjectStatus
            {
                 ProjectStatusID= 1,
                Name = "In Progress"
            },
            new ProjectStatus
            {
                 ProjectStatusID= 2,
                Name = "Completed"
            }
        };

        public static readonly Project[] Projects = 
        {
            new Project
            {
                ProjectID= 1,
                Name = "Grand Mall",
                Address = "123 Al Khan Street",
                Description = "This is the first project",
                StartDate = new DateTime(2023, 10, 10),
                EstimatedCompletionDate = new DateTime(2025, 12, 31),
                StatusID = 1,
            },
             new Project
            {
                 ProjectID= 2,
                Name = "Al Madina Tower",
                Address = "123 Al Emarat Street",
                Description = "This is the second project",
                StartDate = new DateTime(2023, 11, 11),
                EstimatedCompletionDate = new DateTime(2026, 12, 31),
                StatusID = 1,
            }
        };

        public static readonly Payment Payment = new Payment
        {
            PaymentID = 1,
            Amount = 250000000.00,
            OrderID = Guid.NewGuid().ToString(),
            Status = PaymentStatus.Pending
        };

        public static readonly ConstructionRequest[] constructionRequests = 
        {
            new ConstructionRequest
            {
                ConstructionRequestID = 1,
                Description = "First Request Description",
                Remarks = "First Request Remarks",
                StartDate = DateTime.UtcNow,
                EstimatedEndDate = DateTime.UtcNow.AddYears(2),
                PaymentID = 1,
                ClientID = 1,
                ProjectID = 1,
                StatusID = 2,
                CompanyID = 1,
                AddedBy = "TestClient1"
            }
        };

       
    }
}
