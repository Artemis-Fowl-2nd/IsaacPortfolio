extends CharacterBody2D


const speed = 100
var cur_dar = "none"
func _physics_process(delta):
	player_movment(delta)
	pass
	
func player_movment(delta):
	if Input.is_action_pressed("ui_right"):
		play_anim(1)
		cur_dar ="right"
		play_anim(1)
		velocity.x = speed
		velocity.y = 0
	elif Input.is_action_pressed("ui_left"):
		play_anim(1)
		cur_dar = "left"
		velocity.x = -speed
		velocity.y = 0
	elif Input.is_action_pressed("ui_down"):
		play_anim(1)
		cur_dar="down"
		velocity.x = 0
		velocity.y = speed
	elif Input.is_action_pressed("ui_up"):
		play_anim(1)
		cur_dar="up"
		velocity.x = 0
		velocity.y = -speed
	else:
		play_anim(0)
		velocity.x = 0
		velocity.y = 0
	move_and_slide()

func play_anim(move):
	var dir = cur_dar
	var anim = $AnimatedSprite2D
	
	if dir == "right":
		anim.flip_h = false
		if move == 1:
			anim.play("side_walk")
		elif move==0:
			anim.play("side_idle")
	if dir == "left":
		anim.flip_h = true
		if move == 1:
			anim.play("side_walk")
		elif move==0:
			anim.play("side_idle")
	if dir == "down":
		anim.flip_h = true
		if move == 1:
			anim.play("front_walk")
		elif move==0:
			anim.play("front_idle")
	if dir == "up":
		anim.flip_h = true
		if move == 1:
			anim.play("back_walk")
		elif move==0:
			anim.play("back_idle")
		


func _on_area_2d_body_entered(body: Node2D) -> void:
	if body is RigidBody2D:
		var direction = (body.global_position - global_position).normalized()
		body.apply_impulse(Vector2.ZERO, direction * 200)
	pass # Replace with function body.
