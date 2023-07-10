package com;

public class Exception2 {
	public void display() {
	try {
		int i;
		int arr[] = {1,2,3,4,5,6,7,8,9,10};
		for(i=0;i<12;i++) {
			System.out.println(arr[i]);
		}
		
	}
	catch(ArrayIndexOutOfBoundsException ae) {
		System.out.println(ae.getMessage());
	}
	
	
	

}}
