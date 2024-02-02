namespace Name
{
    public class Employee : 
    	{
        	public int Field1{get;set;}
            public string Field2{get;set;}            
            public double Field3{get;set;}
            public string Field4{get;set;}
            public string Field5{get;set;}
        }
    public class ProgramMain{
       public static void Main(){
        Dictionary<int,Employee> myDict=new Dictionary<int, Employee>();
        Employee employee1=new Employee(){Field1=12345,Field2="JohnOne",Field3=15000,Field4="catone",Field5="pen"};
        Employee employee2=new Employee(){Field1=12375,Field2="JohnTwo",Field3=35007,Field4="cattwo",Field5="pencil"};
        Employee employee3=new Employee(){Field1=12945,Field2="JohnThree",Field3=85700,Field4="catthree",Field5="pencap"};
        Employee employee4=new Employee(){Field1=13345,Field2="JohnFour",Field3=19600,Field4="catfour",Field5="penwire"};
        Employee employee5=new Employee(){Field1=12349,Field2="JohnFive",Field3=56070,Field4="catfive",Field5="penphone"};
        
       }
    }
}