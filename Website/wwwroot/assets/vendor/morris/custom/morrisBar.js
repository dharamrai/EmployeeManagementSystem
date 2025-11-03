// Morris Bar Chart
Morris.Bar({
	element: "morrisBar",
	data: [
		{ x: "2023 Q1", y: 2, z: 4, a: 2 },
		{ x: "2023 Q2", y: 5, z: 3, a: 1 },
		{ x: "2023 Q3", y: 2, z: 7, a: 4 },
		{ x: "2023 Q4", y: 5, z: 6, a: 3 },
	],
	xkey: "x",
	ykeys: ["y", "z", "a"],
	labels: ["Y", "Z", "A"],
	resize: true,
	hideHover: "auto",
	gridLineColor: "#cccccc",
	barColors: [
		"#493f94",
		"#5247a7",
		"#5b4fb9",
		"#6b61c0",
		"#7c72c7",
		"#8c84ce",
		"#9d95d5",
		"#ada7dc",
		"#bdb9e3",
		"#cecaea",
	],
});
