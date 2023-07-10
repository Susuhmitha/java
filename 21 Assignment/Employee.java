package com;

public class Employee {
	public int empid;
	public String name;
	public static float salary;
	public Employee() {
		empid = 1;
		name = "sushmitha";
	}
	public Employee(int empid,String name) {
		this.empid = empid;
		this.name = name;
		
	}
	static {
		salary = 50000f;
	}
	public void display() {
		System.out.println("Employee id:"+ empid);
		System.out.println("Employee name:"+ name);
		System.out.println("Employee salary:"+ salary);
		
		
	}

}
