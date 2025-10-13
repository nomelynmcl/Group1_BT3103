using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventDriven.Project.Model;
using EventDriven.Project.BusinessLogic.Repository;

namespace EventDriven.Project.BusinessLogic.Controller
{
    public class StudentRecordController
    {
        private StudentRecordRepository studentRecordRepository;

        public StudentRecordController()
        {
            studentRecordRepository = new StudentRecordRepository();
        }

        public int Add(StudentRecordModel model)
        {
            if (model == null) throw new Exception("missing parameter");

            try
            {

                return studentRecordRepository.Insert(model);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public StudentRecordModel GetById(int id)
        {
            if (id == 0) throw new Exception("missing parameter");
            try
            {

                return studentRecordRepository.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }

}