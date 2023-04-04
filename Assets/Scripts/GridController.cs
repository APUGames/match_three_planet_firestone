using System;
using UnityEngine;


public class GridController : MonoBehaviour
{
    [SerializeField]
    private GameObject piecePrefabBlue;
    [SerializeField]
    private GameObject piecePrefabPurp;
    [SerializeField]
    private GameObject piecePrefabPink;
    [SerializeField]
    private GameObject piecePrefabGreen;
    [SerializeField]
    private GameObject piecePrefabYellow;
    [SerializeField]
    private GameObject piecePrefabOrange;
    //instandiating for differnt positions of prefabs does not work unfortunately

    [SerializeField]
    private Vector3 originPosition;

    //pressdown
    public bool pressedDown;
    public Vector2 pressedDownPosition;
    public GameObject pressedDownGameObject;
    public Vector2 pressedUpPosition;
    public GameObject pressedUpGameObject;


    // This script will manage the grid of pieces
    private Piece [,] grid = new Piece[8, 8];

    // Start is called before the first frame update
    void Start()
    {
        for (int row = 0; row < grid.GetLength(0); row++)
        {
            for (int column = 0; column < grid.GetLength(1); column++)
            {
                Vector3 newWorldPosition = new Vector3(originPosition.x + row, originPosition.y, originPosition.z - column);

                Piece newPiece = new Piece(newWorldPosition, new Vector2(row, column));

                //creating a random grid with the prefabs

                System.Random rand = new System.Random();

                int randomNum = rand.Next(1, 90);

                if(randomNum >= 1 && randomNum < 15)
                {
                    GameObject pieceGameObject = Instantiate(piecePrefabBlue, newPiece.GetPosition(), Quaternion.identity);
                    newPiece.SetPieceType(PieceTypes.Blue);

                    PieceController controller = pieceGameObject.GetComponent<PieceController>();
                    controller.SetPiece(newPiece);
                }
             
                else if  (randomNum >= 15 && randomNum < 30)
                {
                    GameObject pieceGameObject = Instantiate(piecePrefabPurp, newPiece.GetPosition(), Quaternion.identity);

                    //newpiecetype
                    newPiece.SetPieceType(PieceTypes.Purp);

                    PieceController controller = pieceGameObject.GetComponent<PieceController>();
                    controller.SetPiece(newPiece);

                }
                else if (randomNum >= 30 && randomNum < 45)
                {
                    GameObject pieceGameObject = Instantiate(piecePrefabPink, newPiece.GetPosition(), Quaternion.identity);

                    //newpiecetype
                    newPiece.SetPieceType(PieceTypes.Pink);

                    PieceController controller = pieceGameObject.GetComponent<PieceController>();
                    controller.SetPiece(newPiece);
                }
                else if (randomNum >= 45 && randomNum < 60)
                {
                    GameObject pieceGameObject = Instantiate(piecePrefabGreen, newPiece.GetPosition(), Quaternion.identity);

                    //newpiecetype
                    newPiece.SetPieceType(PieceTypes.Green);

                    PieceController controller = pieceGameObject.GetComponent<PieceController>();
                    controller.SetPiece(newPiece);
                }
                else if (randomNum >= 60 && randomNum < 75)
                {
                    GameObject pieceGameObject = Instantiate(piecePrefabYellow, newPiece.GetPosition(), Quaternion.identity);

                    //newpiecetype
                    newPiece.SetPieceType(PieceTypes.Yellow);

                    PieceController controller = pieceGameObject.GetComponent<PieceController>();
                    controller.SetPiece(newPiece);
                }
                else if (randomNum >= 75 && randomNum < 90)
                {
                    GameObject pieceGameObject = Instantiate(piecePrefabOrange, newPiece.GetPosition(), Quaternion.identity);

                    //newpiecetype
                    newPiece.SetPieceType(PieceTypes.Orange);

                    PieceController controller = pieceGameObject.GetComponent<PieceController>();
                    controller.SetPiece(newPiece);
                }

                //set the new piece controller
                grid[row, column] = newPiece;

            }

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
