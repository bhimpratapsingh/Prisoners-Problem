# Prisoners-Problem
 Prisoners problem algorithm to figure out last alive prisoner when prisoner's are killed after every fixed count.

## Explanation:
Suppose there's 5 prisoners and you kill the prisoner at third position and you continue this until single prisoner is alive. 
Note: After killing the prisoner at third position, you cannot start from the first instead you have to continue from fourth prisoner and kill the third prisoner from that position.

**Demonstration:** <br/>
1 2 <strike>3</strike> 4 5                (Here the prisoner at third postion get killed, and then the count starts from 4 to kill the next prisoner) <br/>
<strike>1</strike> 2 <strike>3</strike> 4 5            (Now, after moving from 4..5..1..  prisoner 1 is at the third position, so he get killed)  <br/>
<strike>1</strike> 2 <strike>3</strike> 4 <strike>5</strike>        (Similarly, moving from 2..4..5.. prisoner 5 is at the third position, so he get killed)  <br/>
<strike>1</strike> <strike>2</strike> <strike>3</strike> 4 <strike>5</strike>    (Moving from 2..4..2.. prisoner 2 is at the third position, he get killed and prisoner 4 left alive)  <br/>
