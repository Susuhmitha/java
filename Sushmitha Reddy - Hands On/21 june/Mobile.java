package com;

public class Mobile {
	public String name;
	public int modelId;
	public Mobile() {
		
	}
	public Mobile(String name,int modelId){
		this.modelId = modelId;
		this.name = name;
	}
	public void display() {
		System.out.println("Mobile name is:"+ name);
		System.out.println("mobile id is:"+ modelId);
		
	}

}
