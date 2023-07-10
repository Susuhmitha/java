package com;
import java.io.*;

public class ReaderExample {
	public void readerFile() {
		
		try {
			Reader reader = new FileReader("TestStudent1.java");
			int data = reader.read();
			while(data != -1){
				System.out.println((char)data);
				data = reader.read();
				
				
			}
			reader.close();
		} catch (FileNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
	}

}
