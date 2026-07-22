public class Solution {
    public string PredictPartyVictory(string senate) {
        var charR = 'R';
        var n = senate.Length;
        var span = senate.AsSpan();
        Queue<int> voteR = new(n);
        Queue<int> voteD = new(n);
        for (int i=0; i<n; i++)
        {
            if(span[i] == charR)
                voteR.Enqueue(i);
            else
                voteD.Enqueue(i);
        }
        while(voteR.Count > 0 && voteD.Count > 0)
        {
            var firstR = voteR.Dequeue();
            var firstD = voteD.Dequeue();
            if(firstR < firstD)
                voteR.Enqueue(firstR + n);
            else
                voteD.Enqueue(firstD + n);
        }
        return voteR.Count > 0 ? "Radiant" : "Dire";
    }
}