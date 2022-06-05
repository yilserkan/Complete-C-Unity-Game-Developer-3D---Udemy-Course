# Realm Rush

About the Game:
This game is a strategy game. The enemy castle is producing enemy rams (with object pooling) which are trying to destroy the players castle. The player must stop the enemy rams by placing defense towers. But there is a clue. The rams do not have a prescribed way. If you put your tower on their way they will search a new shortest path via Breadth First Search to the players castel.

Breadth First Search:
1. Queue up the neighbor nodes from start point.
2. Visit the next unexplored node.
3. Queue up the neighbor nodes.
4. Repeat step 2 and 3 until you reach your goal/destination.
5. Follow the path back to create the path.
6. Reverse the list.

Key Takeaways:
- How pathfinding can be implemented to games.
- Object Pooling

![1](https://user-images.githubusercontent.com/80252098/172042540-30a11ad9-5a7c-45e2-8c87-51f5cf43177e.png)
