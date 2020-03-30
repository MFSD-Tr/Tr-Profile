var Nav = 'Open';

function NavOpenClose() {
    
    if (Nav === 'Open') {

        document.getElementById("mySidebar").style.width = "300px";
        document.getElementById("main").style.marginLeft = "300px";

        Nav = 'Close';

        document.getElementById("projectListBtnId").innerHTML = 'X ' + Nav + ' Projects';

    }
    else {

        document.getElementById("mySidebar").style.width = "0";
        document.getElementById("main").style.marginLeft = "0";

        Nav = 'Open';

        document.getElementById("projectListBtnId").innerHTML = '☰ ' + Nav + ' Projects';

    }

}

function ProjectDashboardLoad(projectId) {
    
    $("#main").load("http://localhost:55852/DashBoard/CategoryDashBoard/?categoryId=" + projectId);

}

