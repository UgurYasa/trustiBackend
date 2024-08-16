using Core.Entities;
using Entities.Concrete;

public class Customer : IEntity
{
	public int Customer_No { get; set; }
	public string TCKNo { get; set; }
	public DateTime Birth_Date { get; set; }
	public string First_Name { get; set; }
	public string Last_Name { get; set; }
	public string Email { get; set; }
	public string Phone { get; set; }
	public string Gender { get; set; }
	public string Family_Member { get; set; }
	public int City_Id { get; set; }

	public Customer()
	{
	}
	public Customer(
		int customer_No, string tCKNo, DateTime birth_Date, string first_Name, string last_Name, string email, string phone, string gender, string family_Member, int city_Id)
	{
		Customer_No = customer_No;
		TCKNo = tCKNo;
		Birth_Date = birth_Date;
		First_Name = first_Name;
		Last_Name = last_Name;
		Email = email;
		Phone = phone;
		Gender = gender;
		Family_Member = family_Member;
		City_Id = city_Id;

	}
}
