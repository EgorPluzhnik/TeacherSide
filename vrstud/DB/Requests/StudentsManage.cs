using System;
using System.Collections.Generic;

namespace vrstud.DB
{
    public class StudentsManage
    {
        public StudentsManage(uint groupId, string teacherLogin = null)
        {
            if (teacherLogin is null)
                return;
            #region ChangeItWithDBRequests

            Students = new List<Student>
            {
                new Student
                {
                    FirstName = "Андрей", 
                    LastName = "Фаранов", 
                    PatronymicName = "Антонович", 
                    Id = 1, 
                    GroupId = 1
                },
                new Student
                {
                    FirstName = "Семен", 
                    LastName = "Смрнов", 
                    PatronymicName = "Сергеевич", 
                    Id = 2, 
                    GroupId = 2
                },
                new Student
                {
                    FirstName = "Евгений", 
                    LastName = "Фефилов", 
                    PatronymicName = "Дмитриевич", 
                    Id = 3, 
                    GroupId = 0
                }
            };
            
            #endregion
        }

        public List<Student> Students { get; private set; }
    }
}