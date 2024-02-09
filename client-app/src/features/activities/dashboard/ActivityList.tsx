import React from "react";
import { Activity } from "../../../app/modules/activities";
import {
  Button,
  Item,
  ItemDescription,
  Label,
  Segment,
} from "semantic-ui-react";

interface Props {
  activities: Activity[];
  selectActivity: (id: string) => void;
}

export default function ActivityList({ activities, selectActivity }: Props) {
  return (
    <Segment>
      <Item.Group divided>
        {activities.map((activity) => (
          <Item key={activity.id}>
            <Item.Content>
              <Item.Header as="a"> {activity.title} </Item.Header>
              <Item.Meta>{activity.date} </Item.Meta>
              <ItemDescription>
                <div> {activity.description} </div>
                <div>
                  {" "}
                  {activity.city},{activity.venue}
                </div>
              </ItemDescription>
              <Item.Extra>
                <Button
                  onClick={() => selectActivity(activity.id)}
                  floated="right"
                  content="view"
                  color="blue"
                />
                <Label basic content={activity.category} />
              </Item.Extra>
            </Item.Content>
          </Item>
        ))}
      </Item.Group>
    </Segment>
  );
}