using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Json;


namespace OOP_Task_10_CheWeiHsu
{
    class Program
    {
        static void Main(string[] args)
        {
            ////first deserialize the JSON data into
            ////a generic list of objects
            //List<Client> clients= new List<Client>();
            ////first you try to tell it manually...
            //string thePath = Environment.CurrentDirectory.Replace(@"\bin\Debug", "").Replace(@"\bin\Release", "") + "\\";
            //using (StreamReader file= new StreamReader(thePath+@"Client.json"))
            //{
            //    //StreamReader.ReadToEnd Method
            //    var jsonString = file.ReadToEnd();
            //    //Deserialize:
            //    //clients = JsonConvert.DeserializeObject<List<Client>>(jsonString);
            //    clients = JsonConvert.DeserializeObject<List<Client>>(jsonString);
            //}
            ////Did you get anything?
            //foreach(var c in clients)
            //{
            //    Console.WriteLine(c.FamilyName);
            //}

            //Console.WriteLine("COOL!");

            //first deserialize the JSON data into
            //a generic list of objects
            List<Client> clients = new List<Client>();
            //first you try to tell it manually...
            //string thePath = Environment.CurrentDirectory.Replace(@"\bin\Debug", "").Replace(@"\bin\Release", "") + "\\";
            //Window?
            using (StreamReader file = new StreamReader(@"Client.json"))//未必是json檔案，其也可以是txt檔
                //StreamReader可以把它看作是一個Library, 或者一個Class
            {
                //StreamReader.ReadToEnd Method
                var jsonString = file.ReadToEnd();//ReadToEnd 就是專屬StreamReader的Method
                //Deserialize:
                //clients = JsonConvert.DeserializeObject<List<Client>>(jsonString);
                clients = JsonConvert.DeserializeObject<List<Client>>(jsonString);//在讀取時，需要把json做轉換，而你需要閱讀時，則必須Deserialize
                file.Close();
            }
            //Did you get anything?
            //foreach (var c in clients)
            //{
            //    Console.WriteLine(c.FamilyName);
            //}

            //Add one object to the end of the collection:
            var lastClient = clients.Last();
            clients.Add(new Client(lastClient == null ? 0 : lastClient.Id + 1, "Gyro", "Gearloose", "040 5679128", "gyro.gearloose@edu.xamk.fi", "Cottage", 675.55));

            //Serialize your collection to JSON string
            //true to append data to the file; false to overwrite the file.
            using (StreamWriter file = new StreamWriter(@"Client.json", false))
            {
                string jsonData = JsonConvert.SerializeObject(clients);
                file.Write(jsonData);
                file.Close();

            }
            foreach (var c in clients)
            {
                Console.WriteLine(c.Id + " " + c.FirstName + " " + c.FamilyName);
            }


            //Console.WriteLine("COOL!");
        }
        
    }
}
