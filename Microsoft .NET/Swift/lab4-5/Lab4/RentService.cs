using System.Collections.Generic;
using System;
using System.Linq;

namespace ClassLibraryRentService
{


    ///<summary>
    ///Сервис проката  
    ///</summary>
    public class RentService
    {
        private static RentService _instance;
        /// <summary>
        /// Единственный экземпляр класса RentService
        /// </summary>
        public static RentService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RentService();
                }
                return _instance;
            }
        }
        /// <summary>
        /// Приватный конструктор
        /// </summary>
        private RentService()
        {

        }

        ///<summery>
        /// Словарь клиентов
        ///</summery
        private Dictionary<int, Client> _clients  = new Dictionary<int, Client>();
        ///<summary>
        ///Словарь автомобилей
        ///</summary> 
        private Dictionary<int, Car> _cars = new Dictionary<int, Car>();
        ///<summary>
        ///Список выданных автомобилей
        ///</summary>
       private  List<RentedCar> _rentedCars = new List<RentedCar>();

        /// <summary>
        /// Коллекция клиентов
        /// </summary>
        public IEnumerable<Client> Clients
        {
            get { return _clients.Values.AsEnumerable(); }
        }
        /// <summary>
        /// Коллекция автомобилей
        /// </summary>
        public IEnumerable<Car> Cars
        {
            get
            {
                return _cars.Values.AsEnumerable(); ;
            }
        }
        /// <summary>
        /// Коллекция выданных автомобилей
        /// </summary>
        public IEnumerable<RentedCar> RentedCars
        {
            get
            {
                return _rentedCars;
            }
        }

        public event EventHandler ClientAdded;
        public event EventHandler CarAdded;
        public event EventHandler RentedCarAdded;
        public event EventHandler ClientRemoved;
        public event EventHandler CarRemoved;
        public event EventHandler RentedCarRemoved;

        /// <summary>
        /// Добавление клиента
        /// </summary>
        /// <param name="client">Информация о клиенте</param>
        public void AddClient(Client client)
        {
            if (!client.IsValid)
            {
                throw new InvalidClientException("Информация о клиент заполнена некорректно");
            }
            try
            {
                _clients.Add(client.ClientId, client);
                //Герерируем событие о том, что клиент добавлен
                ClientAdded?.Invoke(client, EventArgs.Empty);
            }
            catch (System.Exception exception)
            {
                throw new InvalidClientException("При добавлении клиента произошла ошибка", exception);
            }
        }
        /// <summary>
        /// Добавление номера
        /// </summary>
        /// <param name="car">Информация о номере</param>
        public void AddCar(Car car)
        {
            if (!car.IsValid)
            {
                throw new InvalidCarException("Информация о автомобиле заполнена некорректно");
            }
            try
            {
                _cars.Add(car.Number, car);
                //Герерируем событие о том, что номер добавлен
                CarAdded?.Invoke(car, EventArgs.Empty);
            }
            catch (System.Exception exception)
            {
                throw new InvalidCarException("При добавлении автомобиля произошла ошибка", exception);
            }
        }
        /// <summary>
        /// Информация о поселении
        /// </summary>
        /// <param name="rentedCar"></param>
        public void AddRentedCar(RentedCar rentedCar)
        {
            if (!rentedCar.IsValid)
            {
                throw new InvalidRentedCarException("Информация о аренде заполнена некорректно");
            }
            try
            {
                _rentedCars.Add(rentedCar);
                //Герерируем событие о том, что информация о поселении добавлена
                RentedCarAdded?.Invoke(rentedCar, EventArgs.Empty);
            }
            catch (System.Exception exception)
            {
                throw new InvalidRentedCarException("При создании акта аренды произошла ошибка", exception);
            }
        }
        /// <summary>
        /// Удалить клиента по идентификатору
        /// </summary>
        /// <param name="clientKey">Идентификатор клиента</param>
        public void RemoveClient(int clientKey)
        {
            _clients.Remove(clientKey);
            ClientRemoved?.Invoke(clientKey, EventArgs.Empty);
            var rentedCarsForClient = RentedCars.Where(s => s.Client.ClientId == clientKey).ToList();
            for (int i = 0; i < rentedCarsForClient.Count; i++)
            {
                RemoveRentedCar(rentedCarsForClient[i]);
            }
        }
        /// <summary>
        /// Удалить номер по идентификатору
        /// </summary>
        /// <param name="carKey"></param>
        public void RemoveCar(int carKey)
        {
            _cars.Remove(carKey);
           
            CarRemoved?.Invoke(carKey, EventArgs.Empty);
  
            var rentedCarsForCar = RentedCars.Where(s => s.Car.Number == carKey).ToList();
            for (int i = 0; i < rentedCarsForCar.Count; i++)
            {
              
                RemoveRentedCar(rentedCarsForCar[i]);
            }
        }
        /// <summary>
        /// Удалить информацию о поселении
        /// </summary>
        /// <param name="rentedCar">Информация о поселении</param>
        public void RemoveRentedCar(RentedCar rentedCar)
        {
            _rentedCars.Remove(rentedCar);
            //Генерируем событие о том, что информация о поселении удалена
            RentedCarRemoved?.Invoke(rentedCar, EventArgs.Empty);
        }



      

    }
}
