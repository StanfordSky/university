using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ClassLibraryBjuro.Exception;

namespace ClassLibraryBjuro
{

    /// <summary>
    /// Бюро по трудоустройству
    /// </summary>

    public class EmploymentAgency
    {
        private static EmploymentAgency _instance;
        /// <summary>
        /// Единственный экземпляр класса EmploymentAgency
        /// </summary>
        public static EmploymentAgency Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EmploymentAgency();
                }
                return _instance;
            }
        }
        /// <summary>
        /// Приватный конструктор
        /// </summary>
        private EmploymentAgency()
        {

        }
        /// <summary>
        /// Словарь работодателей
        /// </summary>
        private Dictionary<int, Employer> _employers = new Dictionary<int, Employer>();
        /// <summary>
        /// Словарь соискателей
        /// </summary>
        private Dictionary<int, JobSeeker> _jobSeekers = new Dictionary<int, JobSeeker>();
        /// <summary>
        /// Список сделок
        /// </summary>
        private List<Dealing> _dealings = new List<Dealing>();

        /// <summary>
        /// Коллекция клиентов
        /// </summary>
        public IEnumerable<Employer> Employers
        {
            get
            {
                return _employers.Values.AsEnumerable();
            }
        }
        /// <summary>
        /// Коллекция номеров
        /// </summary>
        public IEnumerable<JobSeeker> JobSeekers
        {
            get
            {
                return _jobSeekers.Values.AsEnumerable();
            }
        }
        /// <summary>
        /// Коллекция поселений
        /// </summary>
        public IEnumerable<Dealing> Dealings
        {
            get
            {
                return _dealings;
            }
        }

        public event EventHandler EmployerAdded;
        public event EventHandler JobSeekerAdded;
        public event EventHandler DealingAdded;
        public event EventHandler EmployerRemoved;
        public event EventHandler JobSeekerRemoved;
        public event EventHandler DealingRemoved;

        /// <summary>
        /// Добавление работодателя
        /// </summary>
        /// <param name="employer">Информация о работодателе</param>
        public void AddEmployer(Employer employer)
        {
            if (!employer.IsValid)
            {
                throw new InvalidEmployerException("Информация о работодателе заполнена некорректно");
            }
            try
            {
                _employers.Add(employer.EmployerId, employer);
                //Герерируем событие о том, что работодатель добавлен
                EmployerAdded?.Invoke(employer, EventArgs.Empty);
            }
            catch (System.Exception exception)
            {
                throw new InvalidEmployerException("При добавлении работодателя произошла ошибка", exception);
            }
        }
        /// <summary>
        /// Добавление соискателя
        /// </summary>
        /// <param name="jobSeeker">Информация о соискателе</param>
        public void AddJobSeeker(JobSeeker jobSeeker)
        {
            if (!jobSeeker.IsValid)
            {
                throw new InvalidJobSeekerException("Информация о соискателе заполнена некорректно");
            }
            try
            {
                _jobSeekers.Add(jobSeeker.Number, jobSeeker);
                //Герерируем событие о том, что соискатель добавлен
                JobSeekerAdded?.Invoke(jobSeeker, EventArgs.Empty);
            }
            catch (System.Exception exception)
            {
                throw new InvalidJobSeekerException("При добавлении соискателя произошла ошибка", exception);
            }
        }
        /// <summary>
        /// Информация о сделке
        /// </summary>
        /// <param name="dealing"></param>
        public void AddDealing(Dealing dealing)
        {
            if (!dealing.IsValid)
            {
                throw new InvalidDealingException("Информация о сделке заполнена некорректно");
            }
            try
            {
                _dealings.Add(dealing);
                //Герерируем событие о том, что информация о сделке добавлена
                DealingAdded?.Invoke(dealing, EventArgs.Empty);
            }
            catch (System.Exception exception)
            {
                throw new InvalidDealingException("При добавлении сделки произошла ошибка", exception);
            }
        }
        /// <summary>
        /// Удалить работодателя по идентификатору
        /// </summary>
        /// <param name="employerKey">Идентификатор работодателя</param>
        public void RemoveEmployer(int employerKey)
        {
            _employers.Remove(employerKey);
            //Генерируем событие о том, что работодатель удалён
            EmployerRemoved?.Invoke(employerKey, EventArgs.Empty);
            //Получаем список сведений о сделках работодателя
            var dealingsForEmployer = Dealings.Where(s => s.Employer.EmployerId == employerKey).ToList();
            for (int i = 0; i < dealingsForEmployer.Count; i++)
            {
                //Удаляем сведения о поселении клиента
                RemoveDealing(dealingsForEmployer[i]);
            }
        }

        /// <summary>
        /// Удалить соискателя по идентификатору
        /// </summary>
        /// <param name="jobSeekerKey"></param>
        public void RemoveJobSeeker(int jobSeekerKey)
        {
            _jobSeekers.Remove(jobSeekerKey);
            //Генерируем событие о том, что соискатель удалён
            JobSeekerRemoved?.Invoke(jobSeekerKey, EventArgs.Empty);
            //Получаем список сведений о трудоустройстве на работу
            var dealingsForJobSeeker = Dealings.Where(s => s.JobSeeker.Number == jobSeekerKey).ToList();
            for (int i = 0; i < dealingsForJobSeeker.Count; i++)
            {
                //Удаляем сведения о трудоустройстве
                RemoveDealing(dealingsForJobSeeker[i]);
            }
        }
        /// <summary>
        /// Удалить информацию о сделке
        /// </summary>
        /// <param name="dealing">Информация о сделке</param>
        public void RemoveDealing(Dealing dealing)
        {
            _dealings.Remove(dealing);
            //Генерируем событие о том, что информация о поселении удалена
            DealingRemoved?.Invoke(dealing, EventArgs.Empty);
        }
    }
}
