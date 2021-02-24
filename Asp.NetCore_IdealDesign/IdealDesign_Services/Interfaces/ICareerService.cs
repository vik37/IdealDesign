using IdealDesign_Domain.Models;
using IdealDesign_WebModels.VewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdealDesign_Services.Interfaces
{
    public interface ICareerService
    {
        IEnumerable<CareerVM> GetAll();
        CareerVM GetById(int id);
        int CreateCareer(CareerVM model);
        int RemoveCareer(int id);

        string GetFilename(int id);
        IEnumerable<string> GetAllResumes();
    }
}
