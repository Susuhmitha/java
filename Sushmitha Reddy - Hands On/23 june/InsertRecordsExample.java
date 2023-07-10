package com;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.sql.Statement;
public class InsertRecordsExample {
   public static void main(String args[]) throws SQLException {
      //Registering the Driver
      DriverManager.registerDriver(new com.mysql.jdbc.Driver());
      //Getting the connection
      String mysqlUrl = "jdbc:mysql://localhost/MyDatabase";
      Connection con = DriverManager.getConnection(mysqlUrl, "root", "root");
      System.out.println("Connection established......");
      //Creating the Statement
      Statement stmt = con.createStatement();
      //Query to insert records
      String query = "INSERT INTO CUSTOMERS(" + "ID, Name, AGE, SALARY, ADDRESS) VALUES "
         + "(1, 'Amit', 25, 3000, 'Hyderabad'), "
         + "(2, 'Kalyan', 27, 4000, 'Vishakhapatnam'), "
         + "(3, 'Renuka', 30, 5000, 'Delhi'), "
         + "(4, 'Archana', 24, 1500, 'Mumbai'),"
         + "(5, 'Koushik', 30, 9000, 'Kota'),"
         + "(6, 'Hardik', 45, 6400, 'Bhopal'),"
         + "(7, 'Trupthi', 33, 4360, 'Ahmedabad'),"
         + "(8, 'Mithili', 26, 4100, 'Vijayawada'),"
         + "(9, 'Maneesh', 39, 4000, 'Hyderabad'),"
         + "(10, 'Rajaneesh', 30, 6400, 'Delhi'),"
         + "(11, 'Komal', 29, 8000, 'Ahmedabad'),"
         + "(12, 'Manyata', 25, 5000, 'Vijayawada')";
      int i = stmt.executeUpdate(query);
      System.out.println("Rows inserted: "+i);
   }
}