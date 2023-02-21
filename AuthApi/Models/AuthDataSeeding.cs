namespace AuthApi.Models
{
    public static class AuthDataSeeding
    {

        public static readonly AuthUser[] AdminSetterUsers = new AuthUser[] 
        {
            new AuthUser
            {
                AuthUserID = 1,
                Username= "adminSetter",
                Password= "P9U@crCnKg8ncv7",
                EntityStatus = EntityStatus.Active,
                AddedBy = "Default",
                AddedOn = DateTime.UtcNow,
                ChangedBy= "Default",
                ChangedOn = DateTime.UtcNow,
                Role = AuthRoles.AdminSetter
            },
            new AuthUser
            {
                AuthUserID = 2,
                Username= "TestClient1",
                Password= "Test(li3nt1.",
                EntityStatus = EntityStatus.Active,
                AddedBy = "Default",
                AddedOn = DateTime.UtcNow,
                ChangedBy= "Default",
                ChangedOn = DateTime.UtcNow,
                Role = AuthRoles.Client
            },
            new AuthUser
            {
                AuthUserID = 3,
                Username= "TestClient2",
                Password= "Test(li3nt2#",
                EntityStatus = EntityStatus.Active,
                AddedBy = "Default",
                AddedOn = DateTime.UtcNow,
                ChangedBy= "Default",
                ChangedOn = DateTime.UtcNow,
                Role = AuthRoles.Client
            }
        };
    }
}
