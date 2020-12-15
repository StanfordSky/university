using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace ClassLibraryBjuro.Serialization
{
    [Serializable]
    public class EmploymentAgencySerializable
    {
        public List<Employer> Employers { get; set; } = new List<Employer>();
        public List<JobSeeker> JobSeekers { get; set; } = new List<JobSeeker>();
        public List<DealingSerializable> Dealings { get; set; } = new List<DealingSerializable>();

        public static void Save(string fileName, SerializeType type)
        {
            var employmentAgencySerializable = new EmploymentAgencySerializable();
            var employmentAgency = EmploymentAgency.Instance;
            foreach (var employer in employmentAgency.Employers)
            {
                employmentAgencySerializable.Employers.Add(employer);
            }
            foreach (var jobSeeker in employmentAgency.JobSeekers)
            {
                employmentAgencySerializable.JobSeekers.Add(jobSeeker);
            }
            foreach (var dealing in employmentAgency.Dealings)
            {
                employmentAgencySerializable.Dealings.Add(new DealingSerializable
                {
                    EmployerId = dealing.Employer.EmployerId,
                    JobSeekerId = dealing.JobSeeker.Number,
                    Post = dealing.Post,
                    Commission = dealing.Commission
                });
            }
            switch (type)
            {
                case SerializeType.XML:
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(EmploymentAgencySerializable));
                    using (StreamWriter xmlStreamWriter = new StreamWriter(fileName))
                    {
                        xmlSerializer.Serialize(xmlStreamWriter, employmentAgencySerializable);
                    }
                    break;
                case SerializeType.JSON:
                    using (StreamWriter jsonStreamWriter = File.CreateText(fileName))
                    {
                        JsonSerializer jsonSerializer = new JsonSerializer { Formatting = Formatting.Indented };
                        jsonSerializer.Serialize(jsonStreamWriter, employmentAgencySerializable);
                    }
                    break;
                case SerializeType.Binary:
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream binaryFileStream = new FileStream(fileName, FileMode.OpenOrCreate))
                    {
                        formatter.Serialize(binaryFileStream, employmentAgencySerializable);
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }

        public static void Load(string fileName, SerializeType type)
        {
            EmploymentAgencySerializable employmentAgencySerializable;
            switch (type)
            {
                case SerializeType.XML:
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(EmploymentAgencySerializable));
                    StreamReader streamReader = new StreamReader(fileName);
                    employmentAgencySerializable = (EmploymentAgencySerializable)xmlSerializer.Deserialize(streamReader);
                    break;
                case SerializeType.JSON:
                    StreamReader jsonStreamReader = File.OpenText(fileName);
                    JsonSerializer jsonSerializer = new JsonSerializer();
                    employmentAgencySerializable = (EmploymentAgencySerializable)jsonSerializer.Deserialize(jsonStreamReader, typeof(EmploymentAgencySerializable));
                    break;
                case SerializeType.Binary:
                    BinaryFormatter formatter = new BinaryFormatter();
                    FileStream binaryFileStream = new FileStream(fileName, FileMode.Open);
                    employmentAgencySerializable = (EmploymentAgencySerializable)formatter.Deserialize(binaryFileStream);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
            var employmentAgency = EmploymentAgency.Instance;
            var employmentAgencyEmployers = employmentAgency.Employers.ToList();
            var employmentAgencyJobSeekers = employmentAgency.JobSeekers.ToList();
            var employmentAgencyDealings = employmentAgency.Dealings.ToList();
            foreach (var employmentAgencyEmployer in employmentAgencyEmployers)
            {
                employmentAgency.RemoveEmployer(employmentAgencyEmployer.EmployerId);
            }
            foreach (var employmentAgencyJobSeeker in employmentAgencyJobSeekers)
            {
                employmentAgency.RemoveJobSeeker(employmentAgencyJobSeeker.Number);
            }
            foreach (var employmentAgencyDealing in employmentAgencyDealings)
            {
                employmentAgency.RemoveDealing(employmentAgencyDealing);
            }
            var employers = new Dictionary<int, Employer>();
            var jobSeekers = new Dictionary<int, JobSeeker>();
            int maxEmployerId = 0;
            foreach (var employer in employmentAgencySerializable.Employers)
            {
                if (employer.EmployerId > maxEmployerId) maxEmployerId = employer.EmployerId;
                employers.Add(employer.EmployerId, employer);
                employmentAgency.AddEmployer(employer);
            }
            foreach (var jobSeeker in employmentAgencySerializable.JobSeekers)
            {
                jobSeekers.Add(jobSeeker.Number, jobSeeker);
                employmentAgency.AddJobSeeker(jobSeeker);
            }
            foreach (var dealing in employmentAgencySerializable.Dealings)
            {
                employmentAgency.AddDealing(new Dealing
                {
                    Employer = employers[dealing.EmployerId],
                    JobSeeker = jobSeekers[dealing.JobSeekerId],
                    Post = dealing.Post,
                    Commission = dealing.Commission
                });
            }
            Employer.NewEmployerId = maxEmployerId;
        }
    }
}
