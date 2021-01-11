using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace ClassLibraryRentService.Serialization
{
    [Serializable]
    public class RentServiceSerializable
    {
        public List<Client> Clients { get; set; } = new List<Client>();
        public List<Car> Cars { get; set; } = new List<Car>();
        public List<RentSerializable> Rents { get; set; } = new List<RentSerializable>();

        public static void Save(string fileName, SerializeType type)
        {
            var rentServiceSerializable = new RentServiceSerializable();
            var rentService = RentService.Instance;

            foreach (var client in rentService.Clients)
            {
                rentServiceSerializable.Clients.Add(client);
            }
            foreach (var car in rentService.Cars)
            {
                rentServiceSerializable.Cars.Add(car);
            }
            foreach (var rent in rentService.RentedCars)
            {
                rentServiceSerializable.Rents.Add(new RentSerializable
                {
                    ClientId = rent.Client.ClientId,
                    CarId = rent.Car.Number,
                    StartDate = rent.StartDate,
                    EndDate = rent.EndDate
                });
            }
            switch (type)
            {
                case SerializeType.XML:
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(RentServiceSerializable));
                    using (StreamWriter xmlStreamWriter = new StreamWriter(fileName))
                    {
                        xmlSerializer.Serialize(xmlStreamWriter, rentServiceSerializable);
                    }
                    break;
                case SerializeType.JSON:
                    using (StreamWriter jsonStreamWriter = File.CreateText(fileName))
                    {
                        JsonSerializer jsonSerializer = new JsonSerializer { Formatting = Formatting.Indented };
                        jsonSerializer.Serialize(jsonStreamWriter, rentServiceSerializable);
                    }
                    break;
                case SerializeType.Binary:
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream binaryFileStream = new FileStream(fileName, FileMode.OpenOrCreate))
                    {
                        formatter.Serialize(binaryFileStream, rentServiceSerializable);
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }

        }
        public static void Load(string fileName, SerializeType type)
        {
            RentServiceSerializable rentServiceSerializable;
            switch (type)
            {
                case SerializeType.XML:
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(RentServiceSerializable));
                    StreamReader streamReader = new StreamReader(fileName);
                    rentServiceSerializable = (RentServiceSerializable)xmlSerializer.Deserialize(streamReader);
                    break;
                case SerializeType.JSON:
                    StreamReader jsonStreamReader = File.OpenText(fileName);
                    JsonSerializer jsonSerializer = new JsonSerializer();
                    rentServiceSerializable = (RentServiceSerializable)jsonSerializer.Deserialize(jsonStreamReader, typeof(RentServiceSerializable));
                    break;
                case SerializeType.Binary:
                    BinaryFormatter formatter = new BinaryFormatter();
                    FileStream binaryFileStream = new FileStream(fileName, FileMode.Open);
                    rentServiceSerializable = (RentServiceSerializable)formatter.Deserialize(binaryFileStream);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
            var rentService = RentService.Instance;
            var rentServiceClients = rentService.Clients.ToList();
            var rentServiceCars = rentService.Cars.ToList();
            var rentServiceRents = rentService.RentedCars.ToList();
            foreach (var rentServiceClient in rentServiceClients)
            {
                rentService.RemoveClient(rentServiceClient.ClientId);
            }
            foreach (var rentServiceRoom in rentServiceCars)
            {
                rentService.RemoveCar(rentServiceRoom.Number);
            }
            foreach (var rentServiceSettlement in rentServiceRents)
            {
                rentService.RemoveRentedCar(rentServiceSettlement);
            }
            var clients = new Dictionary<int, Client>();
            var rooms = new Dictionary<int, Car>();
            int maxClientId = 0;
            foreach (var client in rentServiceSerializable.Clients)
            {
                if (client.ClientId > maxClientId) maxClientId = client.ClientId;
                clients.Add(client.ClientId, client);
                rentService.AddClient(client);
            }
            foreach (var room in rentServiceSerializable.Cars)
            {
                rooms.Add(room.Number, room);
                rentService.AddCar(room);
            }
            foreach (var settlement in rentServiceSerializable.Rents)
            {
                rentService.AddRentedCar(new RentedCar
                {
                    Client = clients[settlement.ClientId],
                    Car = rooms[settlement.CarId],
                    StartDate = settlement.StartDate,
                    EndDate = settlement.EndDate
                });
            }
            Client.NewClientId = maxClientId;
        }
    }
}