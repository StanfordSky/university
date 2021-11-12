using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace ClassLibraryWork.Serialization
{
    [Serializable]
    public class JobServiceSerializable
    {
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public List<TypeOfWork> TypeOfWorks { get; set; } = new List<TypeOfWork>();
        public List<JobSerializable> Job { get; set; } = new List<JobSerializable>();

        public static void Save(string fileName, SerializeType type)
        {
            var jobServiceSerializable = new JobServiceSerializable();
            var jobService = Human.Instance;

            foreach (var employee in jobService.Employees)
            {
                jobServiceSerializable.Employees.Add(employee);
            }
            foreach (var typeOfWork in jobService.TypeOfWorks)
            {
                jobServiceSerializable.TypeOfWorks.Add(typeOfWork);
            }
            foreach (var Job in jobService.Jobs)
            {
                jobServiceSerializable.Job.Add(new JobSerializable
                {
                    Employee = Job.Worker.EmployeeId,
                    TypeOfWork = Job.Position.PaymentPerDay,
                    StartDate = Job.StartDate,
                    EndDate = Job.EndDate
                });
            }
            switch (type)
            {
                case SerializeType.XML:
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(JobServiceSerializable));
                    using (StreamWriter xmlStreamWriter = new StreamWriter(fileName))
                    {
                        xmlSerializer.Serialize(xmlStreamWriter, jobServiceSerializable);
                    }
                    break;
                case SerializeType.JSON:
                    using (StreamWriter jsonStreamWriter = File.CreateText(fileName))
                    {
                        JsonSerializer jsonSerializer = new JsonSerializer { Formatting = Formatting.Indented };
                        jsonSerializer.Serialize(jsonStreamWriter, jobServiceSerializable);
                    }
                    break;
                case SerializeType.Binary:
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream binaryFileStream = new FileStream(fileName, FileMode.OpenOrCreate))
                    {
                        formatter.Serialize(binaryFileStream, jobServiceSerializable);
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }

        }
        public static void Load(string fileName, SerializeType type)
        {
            JobServiceSerializable jobServiceSerializable;
            switch (type)
            {
                case SerializeType.XML:
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(JobServiceSerializable));
                    StreamReader streamReader = new StreamReader(fileName);
                    jobServiceSerializable = (JobServiceSerializable)xmlSerializer.Deserialize(streamReader);
                    break;
                case SerializeType.JSON:
                    StreamReader jsonStreamReader = File.OpenText(fileName);
                    JsonSerializer jsonSerializer = new JsonSerializer();
                    jobServiceSerializable = (JobServiceSerializable)jsonSerializer.Deserialize(jsonStreamReader, typeof(JobServiceSerializable));
                    break;
                case SerializeType.Binary:
                    BinaryFormatter formatter = new BinaryFormatter();
                    FileStream binaryFileStream = new FileStream(fileName, FileMode.Open);
                    jobServiceSerializable = (JobServiceSerializable)formatter.Deserialize(binaryFileStream);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
            var jobService = Human.Instance;
            var jobServiceEmployee = jobService.Employees.ToList();
            var jobServiceTypeOfWork = jobService.TypeOfWorks.ToList();
            var jobServiceJobs = jobService.Jobs.ToList();
            foreach (var jobServiceEmployees in jobServiceEmployee)
            {
                jobService.RemoveEmployee(jobServiceEmployees.EmployeeId);
            }
            foreach (var jobServiceTypeOfWorks in jobServiceTypeOfWork)
            {
                jobService.RemoveTypeOfWork(jobServiceTypeOfWorks.PaymentPerDay);
            }
            foreach (var jobServiceJobss in jobServiceJobs)
            {
                jobService.RemoveJob(jobServiceJobss);
            }
            var employes = new Dictionary<int, Employee>();
            var typeOfWorkes = new Dictionary<int, TypeOfWork>();
            int maxClientId = 0;
            foreach (var employee in jobServiceSerializable.Employees)
            {
                if (employee.EmployeeId > maxClientId) maxClientId = employee.EmployeeId;
                employes.Add(employee.EmployeeId, employee);
                jobService.AddEmployee(employee);
            }
            foreach (var typeofwork in jobServiceSerializable.TypeOfWorks)
            {
                typeOfWorkes.Add(typeofwork.PaymentPerDay, typeofwork);
                jobService.AddTypeOfWork(typeofwork);
            }
            foreach (var job in jobServiceSerializable.Job)
            {
                jobService.AddJob(new Job
                {
                    Worker = employes[job.Employee],
                    Position = typeOfWorkes[job.TypeOfWork],
                    StartDate = job.StartDate,
                    EndDate = job.EndDate
                });
            }
            Employee.NewEmployeeId = maxClientId;
        }
    }
}