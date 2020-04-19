import React, { Component } from 'react';
import { HeldCards } from './HeldCards';
import { PlayerList } from './PlayerList';
import { Game } from './Game';

export class Home extends Component {
    static displayName = Home.name;

    render() {
        return (
            <div>
                <div className="columns">
                    <div className="column" style={{ backgroundColor: "#FF0000" }}>
                        <Game />
                    </div>
                    <div className="column is-one-fifth" style={{ backgroundColor: "#FFFF00" }}>
                        <PlayerList />
                    </div>
                </div>
                <div className="columns">
                    <div className="column" style={{ backgroundColor: "#FF00FF" }}>
                        <HeldCards />
                    </div>
                </div>
            </div>
        );
    }
}
