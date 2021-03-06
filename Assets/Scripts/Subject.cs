﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subject {
	//A list with observers that are waiting for something to happen
	private List<Observer> observers = new List<Observer>();
	private List<Observer> blockObservers = new List<Observer>();
	private List<Observer> ballObservers = new List<Observer>();

	//Send notifications if something has happened
	public void Notify(string ev, GameObject obj) {
		for (int i = 0; i < observers.Count; i++){
			observers[i].OnNotify(ev, obj);
		}
		
		for (int i = 0; i < blockObservers.Count; i++){
			blockObservers[i].OnNotify(ev, obj);
		}

		for (int i = 0; i < ballObservers.Count; i++){
			ballObservers[i].OnNotify(ev, obj);
		}
	}

	// Add a observer to the list
	public void AddObservers(string subj, Observer obs) {		
		switch (subj.ToLower())
		{
			case "block":
				blockObservers.Add(obs);
				break;
			case "ball":
				ballObservers.Add(obs);
				break;
			default:
				observers.Add(obs);
				break;
		}
	}

	//Remove observer from the list
	public void RemoveObserver(string subj, Observer obs) {
		switch (subj.ToLower())
		{
			case "block":
				blockObservers.Remove(obs);
				break;
			case "ball":
				ballObservers.Remove(obs);
				break;
			default:
				observers.Remove(obs);
				break;
		}
	}
}
