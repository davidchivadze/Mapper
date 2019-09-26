using System;
using System.Collections.Generic;
using System.Linq;
using Models.EntityModels.ExcelLoan;
using Models.EntityModels.Auth;
using System.Text;

namespace Database
{
    public static class DataSeeding
    {
        public static void EnsureDatabaseSeeded(this DataContext dbContext)
        {
            if (!dbContext.UploadFileTypeEntities.Any())
            {
                dbContext.AddRange(new UploadFileType[] {
                    new UploadFileType()
                    {                
                        Description="სამომხმარებლოს სესხის ანალიზის ფორმა",
                        FilesPath="/Files/ConsumerLoan"
                    },
                                        new UploadFileType()
                    {
                        Description="ბიზნეს ანალიზის ფორმა",
                        FilesPath="/Files/Busines"
                    },
                                                            new UploadFileType()
                    {
                        Description="აგრო რეზიუმეს ფორმა",
                        FilesPath="/Files/Agro"
                    },
                });
               
                dbContext.SaveChanges();
            }
            if (!dbContext.VariableTypes.Any())
            {
                dbContext.AddRange(
                    new VariableType[]
                    {
                        new VariableType()
                        {
                            Description="Int",
                         
                        },
                        new VariableType()
                        {
                            Description="Decimal"
                        },
                        new VariableType()
                        {
                            Description ="Nvarchar"
                        }
                    }
                    );
                dbContext.SaveChanges();
            }
            if (!dbContext.ReadFileStatuses.Any())
            {
                dbContext.AddRange(new ReadFileStatus[]
                {
                    new ReadFileStatus
                    {
                        Description="Success"
                    },
                    new ReadFileStatus
                    {
                        Description="Faild"
                    }
                });
                dbContext.SaveChanges();
            }
            if (!dbContext.User.Any())
            {
                dbContext.AddRange(new User[]
                {
                    new User
                    {
                        FirstName="Daviti",
                        LastName="Chivadze",
                        BirthDate=new DateTime(1996,7,10),
                        PIN="35001122068",
                        Address="Dadiani 56",
                        IsDeleted=false,
                        UserName="Admin",
                        Password="21232f297a57a5a743894a0e4a801fc3"
                    }
                });
                dbContext.SaveChanges();
            }
            if (!dbContext.Roles.Any())
            {
                dbContext.AddRange(new Roles[]
                {
                    new Roles
                    {
                        RoleName="Home",
                        Description="Home Page"
                    },

                    new Roles
                    {
                        RoleName="ExcelLoan",
                        Description="Excel Data Reader"
                    }
                });
                dbContext.SaveChanges();
            }
            if (!dbContext.UserRoles.Any())
            {
                var Roles = dbContext.Roles.ToList();
                var User = dbContext.User.FirstOrDefault();
                UserRoles[] RolesForUser = new UserRoles[Roles.Count]; 
                for(int i = 0; i < Roles.Count; i++)
                {
                    RolesForUser[i] = new UserRoles
                    {
                        UserID = User.ID,
                        RoleID = Roles[i].ID
                    };
                }

                dbContext.AddRange(RolesForUser);
                dbContext.SaveChanges();
            }
        }
    }
}
