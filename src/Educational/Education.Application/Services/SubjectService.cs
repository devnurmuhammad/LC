using Education.Application.DTOs;
using Education.Application.Interfaces;
using Education.Application.Repositories;
using Education.Application.VIewModels;
using Education.Domain.Entities;

namespace Education.Application.Services
{
    public class SubjectService : ISubjectService
    {
        private readonly ISubjectRepository _subjectRepository;
        public SubjectService(ISubjectRepository subjectRepository)
        {
            _subjectRepository = subjectRepository;
        }

        public async Task<bool> CreateAsync(SubjectDTO subjectDTO)
        {
            Subject subject = new Subject()
            {
                Name = subjectDTO.Name,
                Description = subjectDTO.Description,
                Duration = subjectDTO.Duration,
            };

            await _subjectRepository.CreateAsync(subject);
            return true;
        }

        public async Task<bool> DeleteAsync(string name)
        {
            Subject subject = await _subjectRepository.GetByNameAsync(name);
            if (subject == null)
            {
                return false;
            }
            await _subjectRepository.DeleteAsync(name);

            return true;
        }

        public async Task<IList<SubjectViewModel>> GetAllAsync()
        {
            IList<Subject> subjects = await _subjectRepository.GetAllAsync();
            IList<SubjectViewModel> result = subjects.Select(x => new SubjectViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                Duration = x.Duration,
            }).ToList();

            return result;
        }

        public async Task<SubjectViewModel> GetByNameAsync(string name)
        {
            Subject subject = await _subjectRepository.GetByNameAsync(name);
            if (subject == null)
                throw new Exception("Not found");

            SubjectViewModel result = new SubjectViewModel()
            {
                Id = subject.Id,
                Name = subject.Name,
                Description = subject.Description,
                Duration = subject.Duration,
            };

            return result;
        }

        public async Task<int> GetCountAsync()
        {
            int count = await _subjectRepository.GetCountAsync();

            return count;
        }

        public async Task<bool> UpdateAsync(string name, SubjectDTO subjectDTO)
        {
            Subject subject = await _subjectRepository.GetByNameAsync(name);
            if (subject == null)
                throw new Exception($"Subject {name} was not found");

            subject.Name = subjectDTO.Name;
            subject.Description = subjectDTO.Description;
            subject.Duration = subjectDTO.Duration;

            await _subjectRepository.UpdateAsync(subject);

            return true;
        }
    }
}
