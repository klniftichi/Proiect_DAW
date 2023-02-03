using Proiect_DAW___Iftichi_Calin.Models;
using Proiect_DAW___Iftichi_Calin.Models.DTOs;
using Proiect_DAW___Iftichi_Calin.Repositories.SediuRepository;

namespace Proiect_DAW___Iftichi_Calin.Services.DemoService
{
    public class JobService : IJobService
    {
        public IJobRepository _jobRepository;

        public JobService(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }

        public JobDTO GetDataMappedByCategory(string category)
        {
            Job job = _jobRepository.GetByCategory(category);

            JobDTO results = new()
            {
                Nume_Job = job.Nume_Job,
                Categorie_job = job.Categorie_job,
                Criterii = job.Criterii,
                Descriere_job = job.Descriere_job,
                CompanieId = job.Companie.CompanieId
            };
            return results;
           

        }
    }
}
