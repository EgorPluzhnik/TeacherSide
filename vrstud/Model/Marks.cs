using System;
using System.Collections.Generic;
using System.Linq;
using vrstud.DB;

namespace vrstud
{
    public class Marks
    {
        private Students _students = new Students();
        private Dictionary<uint, Dictionary<Case, ushort>> _marks = new MarksManage().Marks;
        //do it here: if some students haven't some marks return 0 in that cases
        public Dictionary<Student, Dictionary<Case, ushort>> getMarks(uint? idGroup = null, uint? idStudent = null)
        {
            if (idGroup is null && idStudent is null)
            {
                return _students.StudentsData.ToDictionary(student => student, student => _marks[student.Id]);
                //rewatch possiby throw it
            }

            if (!(idGroup is null) && idStudent is null)
                return _students.StudentsData.Where(student => student.GroupId == idGroup)
                    .ToDictionary(student => student, student => _marks[student.Id]);
            return _students.StudentsData.Where(student => student.Id == idStudent)
                .ToDictionary(student => student, student => _marks[idStudent.Value]);
            //replace all of these filters to db requests argument 
        }
        
        
    }
}