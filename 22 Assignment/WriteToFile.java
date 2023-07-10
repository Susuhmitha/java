package com;
import java.io.*;
import java.util.Scanner;

 


public class WriteToFile {

 

    public void writeData() {
        System.out.println("Entere the Name of file to be Copied : " );
        Scanner sc = new Scanner(System.in);
    String filename1 = sc.next();   // File from which we want to get data 
    System.out.println("Enter the File Name after copied  : ");    
    String filename2 = sc.next();   // File to which data is to be copied

 

        File file = new File("src/com/"+filename1 + ".java");

File file2 = new File("src/com/"+filename2 + ".java" );


     FileInputStream fis=null;
     BufferedInputStream bis=null;
     StringBuilder content= new StringBuilder();

     FileOutputStream fos=null;
     BufferedOutputStream bos=null;

     int data;

     try {
fos = new FileOutputStream(file2); 
bos=new BufferedOutputStream(fos);

         fis = new FileInputStream(file);
         bis=new BufferedInputStream(fis);

         while((data = bis.read()) != -1) {
             content.append((char)data);
         }
        String newcontent= content.toString();
         byte b[]=newcontent.getBytes();    
         bos.write(b);    
         bos.flush();    
         bos.close();    
         fos.close();    
         System.out.println("success");    

     }
             catch(FileNotFoundException fe) {
                 System.out.println("File not found");
             }
             catch(IOException e) {
                 e.printStackTrace();
             }
             finally {
                 if(bis!=null) {
                     try {
                         bis.close();
                     }
                     catch(IOException ie) {
                         ie.printStackTrace();
                     }
                 }
             }

         }
        }                     
