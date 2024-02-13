display unique appointment of all patients---doctor patient
------------------------------------------------------------
```sql
select distnict conact(p.P_first_name,"has an appointment with",d.Dr_first_name) as info from PATIENT p
join APPOINTMENT a on p.Patient_id=a.patient_id
join DOCTOR d on d.Dotor_id=a.Doctor_id
order by info desc;
```
display patient's first name and bill amount---doctor patient
--------------------------------------------------------------
```sql
select p.P_first_name,b.Bill_amount from PATIENTS p
join AAPPOINTMENT a on p.Patient_id=a.Patient_id
join BILL b on b.App_number=a.App_number
order by p.P_first_name desc;
```
display recharge information---mobile prepaid system
-----------------------------------------------------
```sql
select concat( "On ",month(s.RECHARGE_DATE) ,c.CUSTOMER_NAME," recharged his/her ",c.PHONE_NUMBER) as info from CUSTOMER c
join SUBSCRIPTION s on c.PHONE_NUMBER=s.PHONE_NUMBER
order by info asc;
```
customer ordered cakes form february to august-bake off cake ordering
---------------------------------------------------------------------
```sql
select distinct(c.Cust_name,c.Email_id,c.Phone_no) from CUSTOMERS c 
join ORDERS o on c.Cust_id=o.Cust_id
where month(o.Order_date)=>2 and month(o.Order_date)<=8
order by c.Cust_name asc;
```
updated premium amount---insurance management system
-----------------------------------------------------
```sql
select POLICY_ID,POLICY_NAME,BONUS_PERCENTAGE,
when(MINIMUM_YEAR between 1 and 15) then(MINIMUM_PREMIUM_AMOUNT+100)
else(MINIMUM_PREMIUM_AMOUNT+150) end as updated_premium
from POLICY 
order by POLICY_ID desc;
```
birth month with address not include street---insurance management system
--------------------------------------------------------------------------
```sql
select CUSTOMER_ID,CUSTOMER_NAME,month(DATE_OF_BIRTH)
from CUSTOMER
where ADDRESS not like '%street%'
order by CUSTOMER_ID desc;
```
movie released in month---movie ticket booking
-----------------------------------------------
```sql
select contact(m.MOVIE_NAME," released on ",month(s.FROM_DATE)) as MOVIE_MOINTH from MOVIE_MASTER m
join SCREENING_MASTER s on m.MOVIE_ID=s.MOVIE_ID
order by MOVIE_MONTH;
```
flight doesn't arrive at chicago---flight Management system
------------------------------------------------------------
```sql
select Flight_name,Flight_source 
from Flight_details
where Flight_destination in(select Flight_Destination 
from Flight_details 
where Flight_destination<>"Chicago"
group by Flight_destination 
having count(distinct Flight_name)>1)
order by Flight_destination,Flight_name asc;
```
number of customers in each city except mysore---pets
-----------------------------------------------------
```sql
select CITY,count(CUSTOMER_ID) from CUSTOMER_DETAILS
where CITY<>"Mysore"
group by CITY
order by CITY desc;
```
