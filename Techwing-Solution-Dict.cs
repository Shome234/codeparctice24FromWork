using System;
using System.Collections.Generic;
using System.Linq;

class Program{
    public static Dictionary<string,string> vaccinationDetails=new Dictionary<string,string>();
    
    public void AddVaccinationDetails(Dictionary<string,string> dic){
        foreach(var item in dic){
            vaccinationDetails.Add(item.Key,item.Value);
        }
    }
    public List<String> GetEmployeeId(string status){
        return vaccinationDetails.Where(item=>item.Value==status).Select(item=>item.Key).ToList();
    }
    public string UpdateVaccinationStatus(string id,string status){
        if(vaccinationDetails.ContainsKey(id)){
            vaccinationDetails[id]=status;
            return ($"{id}_{status}");
        }
        return null;
    }

  //main is not correct just for testing only but you can modify it accordingly
    public static void Main(){
        int choice;
        Program p=new Program();
        while(true){
            Console.WriteLine("1. add the details");
            Console.WriteLine("2. get id by status");
            Console.WriteLine("3. update details");
            Console.WriteLine("4. exit");
            if(int.TryParse(Console.ReadLine(),out choice)){
                switch(choice){
                    case 1:
                        Console.WriteLine("add id");
                        string id=Console.ReadLine();
                        Console.WriteLine("add status");
                        string status=Console.ReadLine();
                        var d=new Dictionary<string,string>();
                        d.Add(id,status);
                        p.AddVaccinationDetails(d);
                        break;
                    case 2:
                        Console.WriteLine("enter status");
                        string estatus=Console.ReadLine();
                        var li1=p.GetEmployeeId(estatus);
                        if(li1.Count>0){
                            foreach(var i in li1){
                                Console.WriteLine(i);
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("enter id");
                        string eid=Console.ReadLine();
                        Console.WriteLine("enter status");
                        string eestatus=Console.ReadLine();
                        var s=p.UpdateVaccinationStatus(eid,eestatus);
                        Console.WriteLine(s);
                        break;
                    case 4:
                        Console.WriteLine("thank you");
                        return;
                    default:
                        Console.WriteLine("try again");
                        break;
                        
                }
            }
            else{
                Console.WriteLine("enter right choice pleaseee");
            }
        }
    }
}
