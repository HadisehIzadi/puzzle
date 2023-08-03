using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
	public int width;
	public int height;
	public GameObject bgTilePrefab;
	public Gem[] gems;
	public Gem[,] allGems;
	
	// Start is called before the first frame update
	void Start()
	{
		allGems = new Gem[width, height];
		Setup();
		
	}

	// Update is called once per frame
	void Update()
	{
        
	}
    
	private void Setup()
	{
		for (int x = 0; x < width; x++) {
			for (int y = 0; y < height; y++) {
				Vector2 pos = new Vector2(x, y);
				
				GameObject bgTile = Instantiate(bgTilePrefab, pos, Quaternion.identity);
				bgTile.transform.parent = transform;
				bgTile.name = "BG Tile - " + x + ", " + y;
				int gemToUse = Random.Range(0, gems.Length);
				
				SpawnGem(new Vector2Int(x, y), gems[gemToUse]);
				
			}
    	
		}
    	
	}
	
	
	private void SpawnGem(Vector2Int pos, Gem gemToSpawn)
	{
		Gem gem = Instantiate(gemToSpawn, new Vector3(pos.x, pos.y), Quaternion.identity);
        gem.transform.parent = transform;
        gem.name = "Gem - " + pos.x + ", " + pos.y;
        allGems[pos.x, pos.y] = gem;
        
        gem.SetupGem(pos, this);
	}
    
}
