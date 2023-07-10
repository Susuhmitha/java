package com;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.sql.Statement;
public class CreateDatabaseExample {
   public static void main(String args[]) throws SQLException {
      //Registering the Driver
      DriverManager.registerDriver(new com.mysql.jdbc.Driver());
      //Getting the connection
      String mysqlUrl = "jdbc:mysql://localhost/";
      Connection con = DriverManager.getConnection(mysqlUrl, "root", "root");
      System.out.println("Connection established......");
      //Creating the Statement
      Statement stmt = con.createStatement();
      //Query to create a database
      String query = "CREATE database MyDatabase";
      //Executing the query
      stmt.execute(query);
      System.out.println("Database created");
   }
}
