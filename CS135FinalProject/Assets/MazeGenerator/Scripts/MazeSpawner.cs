using UnityEngine;
using System.Collections;

//<summary>
//Game object, that creates maze and instantiates it in scene
//</summary>
public class MazeSpawner : MonoBehaviour
{
	public enum MazeGenerationAlgorithm
	{
		PureRecursive,
		RecursiveTree,
		RandomTree,
		OldestTree,
		RecursiveDivision,
	}

	public MazeGenerationAlgorithm Algorithm = MazeGenerationAlgorithm.PureRecursive;
	public bool FullRandom = false;
	public int RandomSeed = 12345;
	public GameObject Floor = null;
	public GameObject Wall = null;
	public GameObject Door = null;
	public GameObject Pillar = null;
	public GameObject Enemy = null;


	[Range(0f, 1f)]
	public float EnemySpawnPercentage = 0f;
	public int Rows = 5;
	public int Columns = 5;
	public float CellWidth = 5;
	public float CellHeight = 5;
	public float DoorHeight = 2.9f;
	public bool AddGaps = true;
	public GameObject GoalPrefab = null;

	private BasicMazeGenerator mMazeGenerator = null;

	void Start()
	{
		if (!FullRandom)
		{
			Random.seed = RandomSeed;
		}
		switch (Algorithm)
		{
			case MazeGenerationAlgorithm.PureRecursive:
				mMazeGenerator = new RecursiveMazeGenerator(Rows, Columns);
				break;
			case MazeGenerationAlgorithm.RecursiveTree:
				mMazeGenerator = new RecursiveTreeMazeGenerator(Rows, Columns);
				break;
			case MazeGenerationAlgorithm.RandomTree:
				mMazeGenerator = new RandomTreeMazeGenerator(Rows, Columns);
				break;
			case MazeGenerationAlgorithm.OldestTree:
				mMazeGenerator = new OldestTreeMazeGenerator(Rows, Columns);
				break;
			case MazeGenerationAlgorithm.RecursiveDivision:
				mMazeGenerator = new DivisionMazeGenerator(Rows, Columns);
				break;
		}
		mMazeGenerator.GenerateMaze();
		for (int row = 0; row < Rows; row++)
		{
			for (int column = 0; column < Columns; column++)
			{
				float x = column * (CellWidth + (AddGaps ? .2f : 0));
				float z = row * (CellHeight + (AddGaps ? .2f : 0));
				MazeCell cell = mMazeGenerator.GetMazeCell(row, column);
				GameObject tmp;
				tmp = Instantiate(Floor, new Vector3(x, 0, z), Quaternion.Euler(0, 0, 0)) as GameObject;
				tmp.transform.parent = transform;
				// spawning mobs
				// if (Random.value > 1 - EnemySpawnPercentage) //%20 percent chance (1 - 0.8 is 0.2)
				// {
				// 	tmp = Instantiate(Enemy, new Vector3(x, 0, z), Quaternion.Euler(0, 0, 0)) as GameObject;
				// 	tmp.transform.parent = transform;
				// }

				// if the cell is goal, 3/4 sides are enclosed
				// take the opposite wall of the side that is open
				// check all sides and if it is false, place a door the opposite of that wall
				// that will be the side the door will be
				if (cell.IsGoal)
				{
					if (!cell.WallFront)
					{
						// place a door at wallback
						tmp = Instantiate(Door, new Vector3(x, DoorHeight, z - CellHeight / 2) + Wall.transform.position, Quaternion.Euler(0, 90, 0)) as GameObject;// back
						tmp.transform.parent = transform;
						cell.IsBackDoor = true;
					}
					else if (!cell.WallBack)
					{
						// place a door at wallfront
						tmp = Instantiate(Door, new Vector3(x, DoorHeight, z + CellHeight / 2) + Wall.transform.position, Quaternion.Euler(0, -90, 0)) as GameObject;// front
						tmp.transform.parent = transform;
						cell.IsFrontDoor = true;
					}
					else if (!cell.WallRight)
					{
						// place a door at wallleft
						tmp = Instantiate(Door, new Vector3(x - CellWidth / 2, DoorHeight, z) + Wall.transform.position, Quaternion.Euler(0, 180, 0)) as GameObject;// left
						tmp.transform.parent = transform;
						cell.IsLeftDoor = true;
					}
					else if (!cell.WallLeft)
					{
						// place a door at wallright
						tmp = Instantiate(Door, new Vector3(x + CellWidth / 2, DoorHeight, z) + Wall.transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;// right
						tmp.transform.parent = transform;
						cell.IsRightDoor = true;
					}
				}

				// prevent out of range errors
				if (row > 0 && row < Rows - 1 && column > 0 && column < Columns - 1)
				{
					MazeCell cellAbove = mMazeGenerator.GetMazeCell(row + 1, column);
					MazeCell cellBelow = mMazeGenerator.GetMazeCell(row - 1, column);
					MazeCell cellLeft = mMazeGenerator.GetMazeCell(row, column - 1);
					MazeCell cellRight = mMazeGenerator.GetMazeCell(row, column + 1);

					// spawn all right walls except if there is a right door already there
					if (cell.WallRight && !cell.IsRightDoor)
					{
						// if there is left wall in the cell to the right, do not spawn the right wall for this cell
						if (!cellRight.WallLeft)
						{
							tmp = Instantiate(Wall, new Vector3(x + CellWidth / 2, 0, z) + Wall.transform.position, Quaternion.Euler(0, 90, 0)) as GameObject;// right
							tmp.transform.parent = transform;
						}
					}

					if (cell.WallLeft && !cell.IsLeftDoor)
					{
						// if there is Right wall in the cell to the Left, do not spawn the Left wall for this cell
						// if (!cellLeft.WallRight)
						{
							tmp = Instantiate(Wall, new Vector3(x - CellWidth / 2, 0, z) + Wall.transform.position, Quaternion.Euler(0, 270, 0)) as GameObject;// left
							tmp.transform.parent = transform;
						}
					}


					if (cell.WallBack && !cell.IsBackDoor)
					{
						// if there is front wall in the cell to the below, do not spawn the back wall for this cell
						if (!cellBelow.WallFront)
						{
							tmp = Instantiate(Wall, new Vector3(x, 0, z - CellHeight / 2) + Wall.transform.position, Quaternion.Euler(0, 180, 0)) as GameObject;// back
							tmp.transform.parent = transform;
						}
					}


					if (cell.WallFront && !cell.IsFrontDoor)
					{
						// if there is back wall in the cell to the above, do not spawn the front wall for this cell
						// if (!cellAbove.WallBack)
						{
							tmp = Instantiate(Wall, new Vector3(x, 0, z + CellHeight / 2) + Wall.transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;// front
							tmp.transform.parent = transform;
						}
					}

				}
				else
				{
					if ((column != Columns / 2) || (row != 0))
					{
						if (cell.WallBack)
						{
							tmp = Instantiate(Wall, new Vector3(x, 0, z - CellHeight / 2) + Wall.transform.position, Quaternion.Euler(0, 180, 0)) as GameObject;// back
							tmp.transform.parent = transform;
						}
					}
					else // spawn door at exit
					{
						// place a door at wallback
						tmp = Instantiate(Door, new Vector3(x, DoorHeight, z - CellHeight / 2) + Wall.transform.position, Quaternion.Euler(0, 90, 0)) as GameObject;// back
						tmp.transform.parent = transform;
					}

					// Middle first and last walls will not be spawned since an entrance and exit is needed
					if ((column != Columns / 2) || (row != Rows - 1))
					{
						if (cell.WallFront)
						{
							tmp = Instantiate(Wall, new Vector3(x, 0, z + CellHeight / 2) + Wall.transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;// front
							tmp.transform.parent = transform;
						}
					}
					else // spawn door at entrance
					{
						// place a door at wallfront
						tmp = Instantiate(Door, new Vector3(x, DoorHeight, z + CellHeight / 2) + Wall.transform.position, Quaternion.Euler(0, -90, 0)) as GameObject;// front
						tmp.transform.parent = transform;
					}

					// spawn all right walls except if there is a right door already there
					if (cell.WallRight)
					{
						tmp = Instantiate(Wall, new Vector3(x + CellWidth / 2, 0, z) + Wall.transform.position, Quaternion.Euler(0, 90, 0)) as GameObject;// right
						tmp.transform.parent = transform;
					}

					if (cell.WallLeft)
					{

						tmp = Instantiate(Wall, new Vector3(x - CellWidth / 2, 0, z) + Wall.transform.position, Quaternion.Euler(0, 270, 0)) as GameObject;// left
						tmp.transform.parent = transform;
					}
				}

				// spawning mobs at maze position that have walls that enclose 3 of the 4 sides of the cell
				if (cell.IsGoal /*&& GoalPrefab != null*/)
				{
					// tmp = Instantiate(GoalPrefab, new Vector3(x, 1, z), Quaternion.Euler(0, 0, 0)) as GameObject;
					// tmp.transform.parent = transform;
					tmp = Instantiate(Enemy, new Vector3(x, 1, z), Quaternion.Euler(0, 0, 0)) as GameObject;
					tmp.transform.parent = transform;
				}
			}
		}
		if (Pillar != null)
		{
			for (int row = 0; row < Rows + 1; row++)
			{
				for (int column = 0; column < Columns + 1; column++)
				{
					float x = column * (CellWidth + (AddGaps ? .2f : 0));
					float z = row * (CellHeight + (AddGaps ? .2f : 0));
					GameObject tmp = Instantiate(Pillar, new Vector3(x - CellWidth / 2, 0, z - CellHeight / 2), Quaternion.identity) as GameObject;
					tmp.transform.parent = transform;
				}
			}
		}
	}
}
