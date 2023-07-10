package com;
import java.io.*;

 

public class TestStudent1 {

 

    public static void main(String[] args) {
        // TODO Auto-generated method stub
        try {
            Student3 s1 = new Student3(1,"sushmitha");
            FileOutputStream fos = new FileOutputStream("src/com/StudentDetails.java");
            ObjectOutputStream oos = new ObjectOutputStream(fos);
            oos.writeObject(s1);
            oos.flush();
            oos.close();
            System.out.println("Object saved to file!");


        }
        catch(IOException e) {
            System.out.println(e);
        }

 

    }

}