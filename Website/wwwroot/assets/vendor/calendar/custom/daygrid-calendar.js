document.addEventListener("DOMContentLoaded", function () {
	var calendarEl = document.getElementById("dayGrid");
	var calendar = new FullCalendar.Calendar(calendarEl, {
		headerToolbar: {
			left: "prevYear,prev,next,nextYear today",
			center: "title",
			right: "dayGridMonth,dayGridWeek,dayGridDay",
		},
		initialDate: "2023-10-10",
		navLinks: true, // can click day/week names to navigate views
		editable: true,
		dayMaxEvents: true, // allow "more" link when too many events
		events: [
			{
				title: "All Day Event",
				start: "2023-10-01",
				color: "#3c3289",
			},
			{
				title: "Long Event",
				start: "2023-10-07",
				end: "2023-10-10",
				color: "#44389a",
			},
			{
				groupId: 999,
				title: "Birthday",
				start: "2023-10-09T16:00:00",
				color: "#4b3eab",
			},
			{
				groupId: 999,
				title: "Birthday",
				start: "2023-10-16T16:00:00",
				color: "#5d51b3",
			},
			{
				title: "Conference",
				start: "2023-10-11",
				end: "2023-10-13",
				color: "#6f65bc",
			},
			{
				title: "Meeting",
				start: "2023-10-14T10:30:00",
				end: "2023-10-14T12:30:00",
				color: "#8178c4",
			},
			{
				title: "Lunch",
				start: "2023-10-16T12:00:00",
				color: "#938bcd",
			},
			{
				title: "Meeting",
				start: "2023-10-18T14:30:00",
				color: "#a59fd5",
			},
			{
				title: "Interview",
				start: "2023-10-21T17:30:00",
				color: "#b7b2dd",
			},
			{
				title: "Meeting",
				start: "2023-10-22T20:00:00",
				color: "#c9c5e6",
			},
			{
				title: "Birthday",
				start: "2023-10-13T07:00:00",
				color: "#dbd8ee",
			},
			{
				title: "Click for Google",
				url: "http://bootstrap.gallery/",
				start: "2023-10-28",
				color: "#edecf7",
			},
			{
				title: "Interview",
				start: "2023-10-20",
				color: "#a59fd5",
			},
			{
				title: "Product Launch",
				start: "2023-10-29",
				color: "#8178c4",
			},
			{
				title: "Leave",
				start: "2023-10-25",
				color: "#5d51b3",
			},
		],
	});

	calendar.render();
});
