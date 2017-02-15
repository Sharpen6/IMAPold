(define 
(problem Box-boxes5)
(:domain Box-boxes5)
(:goal (and (box-at b0 p1-1) (box-at b1 p2-1)))
(:init
	(and
		(agent-at a1 p2-2)
		(agent-at a2 p1-2)
	(adj p1-1 p2-1)
	(adj p1-1 p1-2)
	(adj p1-2 p2-2)
	(adj p1-2 p1-1)
	(adj p2-1 p1-1)
	(adj p2-1 p2-2)
	(adj p2-2 p1-2)
	(adj p2-2 p2-1)

		(not (heavy b0))
		(oneof (box-at b0 p1-2) (box-at b0 p1-1))
		(not (heavy b1))
		(oneof (box-at b1 p2-2) (box-at b1 p2-1))
	)
)
)
