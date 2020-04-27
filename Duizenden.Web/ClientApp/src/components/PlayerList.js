import React, { Component } from "react";
import * as signalR from "@microsoft/signalr";
import PlayerListRow from './PlayerListRow';
import * as constants from '../constants';

export class PlayerList extends Component {
    constructor(props) {
        super(props);

        this.connection = null;
        this.state = {
            players: []
        };
    }

    componentDidMount() {
        var self = this;

        self.connection = new signalR
            .HubConnectionBuilder()
            .withUrl(`${constants.WEBAPI_ROOT_URL}/playerHub`)
            .build();

        self.connection.on("PlayerJoined", function (playerThatJoined) {
            self.setState(prevState => ({
                players: [...prevState.players, playerThatJoined]
            }));
        });

        self.connection
            .start()
            .then(() => console.info('SignalR Connected'))
            .catch(err => console.error('SignalR Connection Error: ', err));
    }

    componentWillUnmount() {
        this.connection.stop();
    }

    render() {
        return (
            <div>
                <div>Players</div>
                <ul>
                    {this.state.players.map((player, index) => (
                        <PlayerListRow key={index} name={player} />
                    ))}
                </ul>
            </div>
        );
    }
}