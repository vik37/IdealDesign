using AutoMapper;
using IdealDesign_DataAccess.Interfaces;
using IdealDesign_Domain.Models;
using IdealDesign_Services.Interfaces;
using IdealDesign_WebModels.VewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IdealDesign_Services.Services
{
    public class CareerService : ICareerService
    {
        private readonly IRepository<Career> _careerRepo;
        private readonly IMapper _mapper;
        public CareerService(IRepository<Career> careerRepo, IMapper mapper)
        {
            _careerRepo = careerRepo;
            _mapper = mapper;
        }
        public IEnumerable<CareerVM> GetAll()
        {
            return _mapper.Map<List<Career>, List<CareerVM>>(_careerRepo.GetAll().ToList());
        }

        public CareerVM GetById(int id)
        {
            try
            {
                var career = _careerRepo.GetById(id);
                
                CareerVM model = _mapper.Map<CareerVM>(career);
                if (model != null)
                {
                    return model;
                }
                else
                {
                    throw new Exception($"Career with id: {id} does not exist");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
           
        }
        public string GetFilename(int id)
        {
            try
            {
                var career = _careerRepo.GetById(id);
                string filename = career.Resume;
                if(filename != null)
                {
                    return career.Resume;
                }
                else
                {
                    throw new Exception($"File with filename {filename} does not exist!");
                }

                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
        public IEnumerable<string> GetAllResumes()
        {
            try
            {
                var files = _careerRepo.GetAll().Select(x => x.Resume).ToList();
                return files;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }
        public int CreateCareer(CareerVM model)
        {
            try
            {
                if (string.IsNullOrEmpty(model.Firstname) || model.Firstname.Count() < 3)
                {
                    throw new Exception("Can not be empty field!");
                }
                if (string.IsNullOrEmpty(model.Description) || model.Description.Count() < 3)
                {
                    throw new Exception("Can not be empty field!");
                }

                Career career = new Career
                {
                    Id = model.Id,
                    Firstname = model.Firstname,
                    Lastname = model.Lastname,
                    Phone = model.Phone,
                    Description = model.Description,
                    Resume = model.Resume.FileName
                };
                //career.Resume = model.Resume.FileName;
                //var mappedCareer = _mapper.Map<Career>(model);
                return _careerRepo.Insert(career);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }
        

        public int RemoveCareer(int id)
        {
            try
            {
                var career = _careerRepo.GetById(id);
                if (career == null)
                {
                    throw new Exception($"There is not product with id {id}");
                }
                return _careerRepo.Delete(id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }

        
    }
}
