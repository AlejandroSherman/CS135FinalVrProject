using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshBuilder : MonoBehaviour
{
	public List<NavMeshSurface> surfaces = new List<NavMeshSurface>();
	IEnumerator Start()
	{
		// Wait one frame
		yield return null;
		// // get all surfaces from all children.
		// NavMeshSurface[] childSurfaces = GetComponentsInChildren<NavMeshSurface>();
		// // Add all of them to our list.
		// surfaces.AddRange(childSurfaces);

		NavMeshSurface floor = GetComponentInChildren<NavMeshSurface>();
		// collect a floor prefab and wall prefab
		surfaces.Add(floor);

		// now build the navmesh
		for (int i = 0; i < surfaces.Count; i++)
		{
			surfaces[i].BuildNavMesh();
		}
	}

	void Update()
	{
		// NavMeshSurface floor = GetComponentInChildren<NavMeshSurface>();
		// // collect a floor prefab and wall prefab
		// surfaces.Add(floor);

		// for (int i = 0; i < surfaces.Count; i++)
		// {
		// 	surfaces[i].BuildNavMesh();
		// }
	}


}
