using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryWork.Exception;

namespace ClassLibraryWork
{
    /// <summary>
    /// Человек
    /// </summary>
    public class Human
    {
        private static Human _instance;
        /// <summary>
        /// Единственный экземпляр класса Отель
        /// </summary>
        public static Human Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Human();
                }
                return _instance;
            }
        }
        /// <summary>
        /// Приватный конструктор
        /// </summary>
        private Human()
        {

        }
        /// <summary>
        /// Словарь сотрудников
        /// </summary>
        private static Dictionary<int, Employee> _employees { get; } = new Dictionary<int, Employee>();
        /// <summary>
        /// Словарь работ
        /// </summary>
        private static Dictionary<int, TypeOfWork> _typeOfWorks { get; } = new Dictionary<int, TypeOfWork>();
        /// <summary>
        /// Список видов работ
        /// </summary>
        private static List<Job> _jobs { get; } = new List<Job>();


        /// <summary>
        /// Коллекция сотрудников
        /// </summary>
        public IEnumerable<Employee> Employees
        {
            get { return _employees.Values.AsEnumerable(); }
        }
        /// <summary>
        /// Коллекция работ
        /// </summary>
        public IEnumerable<TypeOfWork> TypeOfWorks
        {
            get
            {
                return _typeOfWorks.Values.AsEnumerable();
            }
        }
        /// <summary>
        /// Коллекция сотрудников
        /// </summary>
        public IEnumerable<Job> Jobs
        {
            get
            {
                return _jobs;
            }
        }

        public event EventHandler EmployeeAdded;
        public event EventHandler TypeOfWorkAdded;
        public event EventHandler JobAdded;
        public event EventHandler EmployeeRemoved;
        public event EventHandler TypeOfWorkRemoved;
        public event EventHandler JobRemoved;

        /// <summary> 
        /// Добавление сотрудника 
        /// </summary> 
        /// <param name="Employee">Информация о сотруднике</param>
        public void AddEmployee(Employee employee)
        {
            if (!employee.IsValid)
            {
                throw new InvalidEmployeeException("Информация о сотруднике заполнена некорректно");
            }
            try
            {
                _employees.Add(employee.EmployeeId, employee);  //Герерируем событие о том, что клиент  добавлен 
                EmployeeAdded?.Invoke(employee, EventArgs.Empty);
            }
            catch (System.Exception exception)
            {
                throw new InvalidEmployeeException("При добавлении клиента произошла ошибка", exception);
            }
        }

        /// <summary> 
        /// Добавление вида работы 
        /// </summary> 
        /// <param name="TypeOfWork">Информация о виде работы</param>
        public void AddTypeOfWork(TypeOfWork typeOfWork)
        {
            if (!typeOfWork.IsValid)
            {
                throw new InvalidTypeOfWorkException("Информация о сотруднике заполнена некорректно");
            }
            try
            {
                _typeOfWorks.Add(typeOfWork.TypeOfWorkId, typeOfWork);  //Герерируем событие о том, что клиент  добавлен 
                TypeOfWorkAdded?.Invoke(typeOfWork, EventArgs.Empty);
            }
            catch (System.Exception exception)
            {
                throw new InvalidTypeOfWorkException("При добавлении клиента произошла ошибка", exception);
            }
        }

        /// <summary> 
        /// Добавление работ 
        /// </summary> 
        /// <param name="Job">Информация о работе</param>
        public void AddJob(Job job)
        {
            if (!job.IsValid)
            {
                throw new InvalidJobException("Информация о сотруднике заполнена некорректно");
            }
            try
            {
                _jobs.Add(job); 
                JobAdded?.Invoke(job, EventArgs.Empty);
            }
            catch (System.Exception exception)
            {
                throw new InvalidJobException("При добавлении клиента произошла ошибка", exception);
            }
        }

        /// <summary> 
        /// Удалить сотрудника по идентификатору
        /// </summary> 
        /// <param name="employeeKey">Идентификатор сотрудника</param>
        public void RemoveEmployee(int employeeKey)
        {
            _employees.Remove(employeeKey);
            EmployeeRemoved?.Invoke(employeeKey, EventArgs.Empty); 
            var JobForEmployee = Jobs.Where(s  => s.Worker.EmployeeId == employeeKey).ToList();  
            for (int i = 0; i < JobForEmployee.Count;  i++) 
            {
                RemoveJob(JobForEmployee[i]); 
            } 
            
        }

        /// <summary>
        /// Удалить вид работы по идентификатору
        /// </summary>
        /// <param name="typeOfWorkID"></param>
        public void RemoveTypeOfWork(int typeOfWorkKey)
        {
            _typeOfWorks.Remove(typeOfWorkKey);
            TypeOfWorkRemoved?.Invoke(typeOfWorkKey, EventArgs.Empty);

            var jobForTypeOfWork = Jobs.Where(s => s.Position.TypeOfWorkId == typeOfWorkKey).ToList();
            for (int i = 0; i < jobForTypeOfWork.Count; i++)
            {
                RemoveJob(jobForTypeOfWork[i]);
            }
        }


        /// <summary>
        /// Удалить информацию о работе
        /// </summary>
        /// <param name="job">Информация о работе</param>
        public void RemoveJob(Job job)
        {
            _jobs.Remove(job);
            JobRemoved?.Invoke(job, EventArgs.Empty);
        }

    }
}
