package com;

import java.io.BufferedReader;

import java.io.FileReader;

import java.io.IOException;

public class ReadCSVExample2{
	public  static void main(String[] args){

	String line="";

	String splitBy =",";

	try{

	BufferedReader br = new BufferedReader(new FileReader("C:\\Users\\surchauh4\\Documents\\CSVDemo.csv"));

	while((line = br.readLine()) != null){

	String[] employee=line.split(splitBy);

System.out.println("Employee[FirstName="+employee[0]+  ",LastName="+employee[1]+",Designation="+ employee[2] + ",Contact="+ employee[3] + ", Salary="+employee[4]+",City="+employee[5]+"]"); 

	}

	}

	catch(IOException e){
		e.printStackTrace(); 

	}

	} 
	

}
	

	
