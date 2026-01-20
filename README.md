[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/7qg5CCgx)
# HW2
## Devlog
Write your Devlog here!
Write about how the plan you wrote in the MG2 break-down activity connects to the code you wrote. Cite specific class names and method names in the code and GameObjects in your Unity Scene.

The plan I wrote in MG2 activity connects to the code I wrote because I drafted the components that each GameObject would have which would help me decide what attributes and actions the GameObject 
needed to be coded for. For the Player/Penguin GameObject I wrote down that it would need to have a SpriteRenderer, Collider, and Transform component. Having the collider component on
the Penguin means that another GameObject, which is the Coin also needed a collider component. To properly detect collisions, I attached a RigidBody on the Penguin GameObject. I wrote a collision method:
private void OnTriggerEnter2D(Collider2D collision) and inside the method, I coded for if the player touched the coin, it would gain a coin which updated the UI and also destory the Coin GameObject. 
The transform component meant that the Penguin needed to have movement. For this, I coded if (Input.GetKeyDown(KeyCode.Space) && _isGrounded) {_playerRigidbody.AddForce(Vector2.up * _jump, ForceMode2D.Impulse); _isGrounded = false;}
so that once the player presses space, the Penguin would be able to jump only if it is on the ground. 

For the Coin GameObject I wrote that it had the components, Transform, Spriterenderer, and also Collider. The transform is needed on the Coin so that it can move to the left and also to figure out the 
position of the Coin so that it can be destroyed once off screen. I wrote the following code in the Update method to carry out these actions: transform.Translate(Vector2.left * _moveSpeed * Time.deltaTime);
if (transform.position.x < _destroyCoin { Destroy(gameObject); return; } 

For the GameController, I wrote that it would have # of points, point text, coin spawn location, and a coin prefab. The coin spawn location and coin prefab would be needed to instantiate the 
Coin GameObject. For this, I wrote the following code in SpawnCoin() method: Instantiate(_coinPrefab, spawnPosition, UnityEngine.Quaternion.identity); where spawnPosition was a specific spot in the scene
that the Penguin GameObject was able to reach once it jumped. The point text needed to be updated every time the Penguin touched a coin so I wrote the following code to achieve this: 
public void UpdateCoinText(int coinCollected) { _coinPoints.text = "Points: " + coinCollected; } where coinCollected is the number of points. 
 
## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - rabbit and item sprites
- [Pixel Penguin 32x32 Asset pack](https://legends-games.itch.io/pixel-penguin-32x32-asset-pack) - penguin sprites
- [Coins 2D](https://artist2d3d.itch.io/2d) - coin sprites