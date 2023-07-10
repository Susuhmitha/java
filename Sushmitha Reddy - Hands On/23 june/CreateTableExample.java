package com;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.sql.Statement;
public class CreateTableExample {
   public static void main(String args[]) throws SQLException {
      //Registering the Driver
      DriverManager.registerDriver(new com.mysql.jdbc.Driver());
      //Getting the connection
      String mysqlUrl = "jdbc:mysql://localhost/MyDatabase";
      Connection con = DriverManager.getConnection(mysqlUrl, "root", "root");
      System.out.println("Connection established......");
      //Creating the Statement
      Statement stmt = con.createStatement();
      //Query to create a table
      String query = "CREATE TABLE CUSTOMERS("
         + "ID INT NOT NULL, "
         + "NAME VARCHAR (20) NOT NULL, "
         + "AGE INT NOT NULL, "
         + "SALARY DECIMAL (18, 2), "
         + "ADDRESS CHAR (25) , "
         + "PRIMARY KEY (ID))";
      stmt.execute(query);
      System.out.println("Table Created......");
   }
}