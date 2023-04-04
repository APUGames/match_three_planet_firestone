using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PieceTypes
{
    Blue = 1,
    Purp = 2,
    Pink = 3,
    Green = 4,
    Yellow = 5,
    Orange = 6
}
public class Piece 
{
    private Vector3 position;
    private Vector2 gridPosition;
    private PieceTypes pieceType;
    

    public Piece()
    {
        position = Vector3.zero;
        gridPosition = Vector2.zero;
    
    }

    public Piece (Vector3 position, Vector2 gridPosition)
    {
        this.position = position;
        this.gridPosition = gridPosition;
    }

    public Vector3 GetPosition()
    {
        return position;
    }
    public Vector2 GetGridPosition()
    {
        return gridPosition;
    }

    public void SetPieceType(PieceTypes pieceType)
    {
        this.pieceType = pieceType;
    }

    public PieceTypes GetPieceType()
    {
        return pieceType;
    }
}
