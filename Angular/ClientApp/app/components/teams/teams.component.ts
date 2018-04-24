import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'teams',
    templateUrl: './teams.component.html'
})


export class TeamsComponent {
    public teams: Teams[];

    public cacheTeams: Teams[];

    public ddTeams: Teams[];



    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        //teams
        http.get(baseUrl + 'api/Player/GetPlayers', { params: {teamid:1}}).subscribe(result => {
            this.teams = result.json() as Teams[];
            this.cacheTeams = this.teams;
            this.ddTeams = this.teams;
        }, error => console.error(error));
    }

    filterTeams(filterVal: any) {
        if (filterVal == "0")
            this.teams = this.cacheTeams;
        else
            this.teams = this.cacheTeams.filter((item) => item.id == filterVal);
    }
}


interface Teams {
    id: number;
    teamName: string;
}