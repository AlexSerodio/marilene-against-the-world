using UnityEngine;

public class Player : MonoBehaviour {
    
	private int mLives = 3;
	private int mScore = 0;

	public int Lives {
        get {
            return mLives;
        }
        set {
            mLives = value;
        }
    }

    public int Score {
        get {
            return mScore;
        }
        set {
            mScore = value;
        }
    }

}
